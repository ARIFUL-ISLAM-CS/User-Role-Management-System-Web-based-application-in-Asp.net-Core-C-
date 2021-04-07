using EmployeeManagementSystem.Attributes.Authorize;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize]
    public class Model : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public Model(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewData["Create"] = RolesForMenu.GetMenu(User.Identity.Name, "Model", "Create");
            ViewData["Edit"] = RolesForMenu.GetMenu(User.Identity.Name, "Model", "Edit");
            ViewData["Delete"] = RolesForMenu.GetMenu(User.Identity.Name, "Model", "Delete");

            return View(_context.employeeVMs.ToList());
        }
        [HttpGet]
        [CustomAuthorize("Model", "Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [CustomAuthorize("Model", "Create")]
        public async Task<ActionResult> Create(EmployeeVM _employee)
        {
            if (ModelState.IsValid)
            {
                string Image = "";

                var files = HttpContext.Request.Form.Files;
                foreach (var img in files)
                {
                    if (img != null && img.Length > 0)
                    {
                        var file = img;

                        var uploads = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                        if (file.Length > 0)
                        {
                            // var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                Image = fileName;
                            }

                        }
                    }
                }

                var data = new EmployeeVM()
                {
                    EmployeeName = _employee.EmployeeName,
                    ProjectName = _employee.ProjectName,
                    Quantity = _employee.Quantity,
                    Price = _employee.Price,
                    IssueDate = _employee.IssueDate,
                    Image = Image,
                };

                _context.employeeVMs.Add(data);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            return View(_employee);
        }

        [HttpGet]
        [CustomAuthorize("Model", "Edit")]
        public ActionResult Edit(int id)
        {
            var employee = _context.employeeVMs.Find(id);
            return View(employee);
        }

        // POST: Product/Edit/5
        [HttpPost]
        [CustomAuthorize("Model", "Edit")]
      
        public async Task<ActionResult> Edit(int id, EmployeeVM _employee)
        {
            if (ModelState.IsValid)
            {
                string Image = "";
                var files = HttpContext.Request.Form.Files;
                foreach (var img in files)
                {
                    if (img != null && img.Length > 0)
                    {
                        var file = img;

                        var uploads = Path.Combine(_hostEnvironment.WebRootPath, "Images");
                        if (file.Length > 0)
                        {
                            // var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                            var fileName = Guid.NewGuid().ToString().Replace("-", "") + file.FileName;
                            using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                            {
                                await file.CopyToAsync(fileStream);
                                Image = fileName;
                            }

                        }
                    }
                }
                var data = _context.employeeVMs.Find(id);
                data.EmployeeName = _employee.EmployeeName;
                data.ProjectName = _employee.ProjectName;
                data.Quantity = _employee.Quantity;
                data.Price = _employee.Price;
                data.IssueDate = _employee.IssueDate;
                data.Image = Image;
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(_employee);
        }
        [HttpPost,HttpGet]
        [CustomAuthorize("Model", "Delete")]
        public async Task<ActionResult> Delete(int id)
        {
            var data = _context.employeeVMs.Find(id);
            _context.employeeVMs.Remove(data);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
