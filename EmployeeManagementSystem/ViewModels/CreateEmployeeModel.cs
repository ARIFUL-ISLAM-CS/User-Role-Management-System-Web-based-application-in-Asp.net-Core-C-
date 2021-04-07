﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels
{
    public class CreateEmployeeModel
    {
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Player Name Is Required")]
        [DataType(DataType.Text)]
        [Display(Name = "Player Name")]
        [StringLength(50, ErrorMessage = "Player Name Must be within 50 Charecter")]
        public string Name { get; set; }
    
        public DateTime DoB { get; set; }
        [Required(ErrorMessage = "Team Is Required")]
        public string Group { get; set; }
        [Required(ErrorMessage = "Email Is Required")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone Is Required")]
        public string Phone { get; set; }
        [Range(10000, 50000, ErrorMessage = "Salary must be between 10,000 to 50,000")]
        public decimal Salary { get; set; }
        public string ImageName { get; set; }
        public string ImageUrl { get; set; }
      
        
        public IFormFile ImageFile { get; set; }
     
    }
}
