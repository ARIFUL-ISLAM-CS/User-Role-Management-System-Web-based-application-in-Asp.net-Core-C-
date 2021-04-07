using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class tblEmployee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public string Salery { get; set; }

        public DateTime JoiningDate { get; set; }

        public string ImageName { get; set; }

        public string ImageUrl { get; set; }
    }
}
