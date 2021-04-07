using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using EmployeeManagementSystem.Attributes.Authorize;

namespace EmployeeManagementSystem.Controllers
{
    [Authorize]
    public class AjaxCrud : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AjaxCrud(IWebHostEnvironment hostingEnvironment ,ApplicationDbContext context)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Index()
        {
            ViewData["AddNewEmployee"] = RolesForMenu.GetMenu(User.Identity.Name, "AjaxCrud", "AddNewEmployee");
           
            return View(_context.employeeAjaxes.ToList());
        }
        [HttpGet]
        [HttpPost]
        [CustomAuthorize("AjaxCrud", "AddNewEmployee")]
        public ActionResult AddNewEmployee()
        {
            return View(_context.employeeAjaxes.ToList());
        }
        
        //[ValidateAntiForgeryToken]
        //[CustomAuthorize("AjaxCrud", "AddNewEmployee")]
        [HttpPost]
        public ActionResult SaveData(CreateEmployeeModel item)
        {
            string uniqueFile = ProcessUploadFile(item);
            EmployeeAjax item1;
            if (item.EmployeeID == 0)
            {
                item1 = new EmployeeAjax();                
                item.ImageUrl = uniqueFile;                
                
                item1.DoB = item.DoB;
                item1.Name = item.Name;
                item1.Email = item.Email;
                item1.Phone = item.Phone;
                item1.Group = item.Group;
                item1.Salary = item.Salary;
                item1.ImageName = item.ImageName;
                item1.ImageUrl = item.ImageUrl;
                _context.employeeAjaxes.Add(item1);
                _context.SaveChanges();
            }
            else
            {
                item1 = _context.employeeAjaxes.SingleOrDefault(p => p.EmployeeID == item.EmployeeID);
                item.ImageUrl = uniqueFile;
                item1.EmployeeID = item.EmployeeID;
                
                item1.DoB = item.DoB;
                item1.Name = item.Name;
                item1.Email = item.Email;
                item1.Phone = item.Phone;
                item1.Group = item.Group;
                item1.Salary = item.Salary;
                item1.ImageName = item.ImageName;
                item1.ImageUrl = item.ImageUrl;
                //db.players.Add(item);
                _context.SaveChanges();
            }
            var result = "Successfully Added";
            return Json(result);
        }

        private string ProcessUploadFile(CreateEmployeeModel viewobj)
        {
            string uniqueFileName = null;
            var files = HttpContext.Request.Form.Files;
            foreach (var image in files)
            {
                if (image != null && image.Length > 0)
                {
                    var file = image;
                    var uploadFile = Path.Combine(_hostingEnvironment.WebRootPath, "Images");
                    if (file.Length > 0)
                    {
                        var fileName = file.FileName;
                        using (var fileStream = new FileStream(Path.Combine(uploadFile, fileName), FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                            uniqueFileName = fileName;
                        }
                    }

                }
            }

            return uniqueFileName;
        }

        public JsonResult GetEmployeeList()
        {
            var EmployeeList = _context.employeeAjaxes.Where(p => p.EmployeeID > 0).Select(p => new CreateEmployeeModel
            {
                EmployeeID = p.EmployeeID,
                Name = p.Name,
                Group = p.Group,
                DoB = p.DoB,
                Email = p.Email,
                Phone = p.Phone,
                Salary = p.Salary,
                ImageUrl = p.ImageUrl
            }).ToList();
            return Json(EmployeeList);
        }
        public JsonResult GetEmployeeById(int EmployeeID)
        {
            EmployeeAjax obj = _context.employeeAjaxes.Where(p => p.EmployeeID == EmployeeID).SingleOrDefault();
            string value = "";
            value = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
            return Json(value);
        }
       
        public PartialViewResult GetEmployeeDetails(int employeeId)
        {
            EmployeeAjax obj = _context.employeeAjaxes.Where(p => p.EmployeeID == employeeId).SingleOrDefault();
            EmployeeListViewModel vObj = new EmployeeListViewModel();
            vObj.EmployeeID = obj.EmployeeID;
            vObj.Name = obj.Name;
            vObj.Group = obj.Group;
            vObj.DoB = obj.DoB;
            vObj.Email = obj.Email;
            vObj.Phone = obj.Phone;
            vObj.Salary = obj.Salary;
            vObj.ImageUrl = obj.ImageUrl;
            //vObj.GradeName = obj.Grade.GradeName;
            return PartialView("_EmployeeDetailsPartial", vObj);
        }
        [HttpPost,HttpPost]
        [CustomAuthorize("AjaxCrud", "deleteRecord")]

        public ActionResult deleteRecord(int Id)
        {
            bool result = false;
            EmployeeAjax obj = _context.employeeAjaxes.Where(p => p.EmployeeID == Id).SingleOrDefault();
            if (obj != null)
            {
                _context.employeeAjaxes.Remove(obj);
                _context.SaveChanges();
                result = true;
            }
            return View();
        }
    }
}
