using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagementSystem.ViewModels;

namespace EmployeeManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
      
        public DbSet<EmployeeVM> employeeVMs { get; set; }
        public DbSet<EmployeeAjax> employeeAjaxes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<tblEmployee> tblEmployees { get; set; }
        public DbSet<EmployeeManagementSystem.ViewModels.EmployeeVM> EmployeeVM { get; set; }
        

    }
}
