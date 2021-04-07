using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels.NewViewModel
{
    public class EmployeeListViewModel
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Salery { get; set; }
        public System.DateTime JoiningDate { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
    }
}
