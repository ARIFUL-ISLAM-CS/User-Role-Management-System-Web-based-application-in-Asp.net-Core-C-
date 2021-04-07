using EmployeeManagementSystem.Attributes.Authorize;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels.NewViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize]
    public class ViewModel : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public ViewModel(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Index(string filter, int page = 1, string sortExpression = "EmployeeName")
        {
                  
            ViewData["Create"] = RolesForMenu.GetMenu( User.Identity.Name,"ViewModel", "Create");
            ViewData["Edit"] = RolesForMenu.GetMenu(User.Identity.Name, "ViewModel", "Edit");
            ViewData["Delete"] = RolesForMenu.GetMenu(User.Identity.Name, "ViewModel", "Delete");
            //return View(await _context.EmployeeCreateViewModel.ToListAsync());
            var qry = _context.tblEmployees.AsNoTracking()
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(filter))
            {
                qry = qry.Where(p => p.EmployeeName.Contains(filter));
            }
            var model = await PagingList.CreateAsync(qry, 2, page, sortExpression, "EmployeeName");
            model.RouteValue = new RouteValueDictionary
            {
                {"filter",filter }
            };
            return View(model);
        }
        [HttpPost, HttpGet]
        [CustomAuthorize("ViewModel", "Create")]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        [HttpPost]
       
        public async Task<IActionResult> AddOrEdit(EmployeeCreateViewModel viewObj)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            var result = false;
            string fileName = Path.GetFileNameWithoutExtension(viewObj.ImageFile.FileName);
            string extension = Path.GetExtension(viewObj.ImageFile.FileName);
            string fileWithExtension = fileName + extension;
            tblEmployee trObj = new tblEmployee();
            trObj.EmployeeName = viewObj.EmployeeName;
            trObj.Salery = viewObj.Salery;
            trObj.JoiningDate = viewObj.JoiningDate;
            trObj.ImageName = fileWithExtension;
            trObj.ImageUrl = wwwRootPath + "/Images/" + fileName + extension;
            string serverPath = Path.Combine(wwwRootPath + "/Images/" + fileName + extension);
            using (var fileStream = new FileStream(serverPath, FileMode.Create))
            {
                await viewObj.ImageFile.CopyToAsync(fileStream);
            }
            //viewObj.ImageFile.CopyToAsync(serverPath);
            if (ModelState.IsValid)
            {
                if (viewObj.EmployeeId == 0)
                {
                    _context.tblEmployees.Add(trObj);
                    _context.SaveChanges();
                    result = true;
                }
                else
                {
                    trObj.EmployeeId = viewObj.EmployeeId;
                    _context.Entry(trObj).State = EntityState.Modified;
                    _context.SaveChanges();
                    result = true;
                }
            }
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                if (viewObj.EmployeeId == 0)
                {
                    return View("Create");
                }
                else
                {
                    return View("Edit");
                }
            }
        }
       

        [HttpPost, HttpGet]
        [CustomAuthorize("ViewModel", "Edit")]
        
        public IActionResult Edit(int id)
        {
            tblEmployee trObj = _context.tblEmployees.SingleOrDefault(t => t.EmployeeId == id);
            EmployeeCreateViewModel viewObj = new EmployeeCreateViewModel();
            viewObj.EmployeeId = trObj.EmployeeId;
            viewObj.EmployeeName = trObj.EmployeeName;
            viewObj.Salery = trObj.Salery;
            viewObj.JoiningDate = trObj.JoiningDate;
            viewObj.ImageUrl = trObj.ImageUrl;
            viewObj.ImageName = trObj.ImageName;
            return View(viewObj);
        }
        //[HttpGet]
        //[CustomAuthorize("ViewModel", "Delete")]
        //public IActionResult Delete()
        //{
        //    return View();
        //}

        [HttpPost,HttpGet]
        [CustomAuthorize("ViewModel", "Delete")]
       
        public IActionResult Delete(int? id)
        {
            tblEmployee trObj = _context.tblEmployees.SingleOrDefault(t => t.EmployeeId == id);
            {
                _context.tblEmployees.Remove(trObj);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        //private bool EmployeeCreateViewModelExists(int id)
        //{
        //    return _context.EmployeeCreateViewModel.Any(e => e.EmployeeId == id);
        //}
    }
}
