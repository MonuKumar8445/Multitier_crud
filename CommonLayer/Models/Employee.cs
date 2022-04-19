using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CommonLayer.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "Employee Name can't Empty !")]
        [MinLength(3, ErrorMessage = "Name must be minimum 3 char !")]
        [MaxLength(30, ErrorMessage = "Name must be maximum 30 char !")]
        public string Name { get; set; }
        [Display(Name = "Employee Age")]
        [Required(ErrorMessage = "Employee Age can't Empty !")]
        [MinLength(2, ErrorMessage = "Age must be minimum 2 Integer !")]
        [MaxLength(2, ErrorMessage = "Age must be maximum 2 integer !")]
        public string Age { get; set; }
        [Display(Name = "Employee Salary")]
        [Required(ErrorMessage = "Employee Salary can't Empty !")]
        [MinLength(3, ErrorMessage = "Salary must be minimum 3 Integer !")]
        [MaxLength(30, ErrorMessage = "Salary must be maximum 30 integer !")]
        public string Salary { get; set; }
        [Display(Name = "Employee Phone")]
        [Required(ErrorMessage = "Employee Phone can't Empty !")]
        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$", ErrorMessage = "Invalid Phone Number !")]
        public string Phone { get; set; }
        [Display(Name = "Employee City")]
        [Required(ErrorMessage = "Employee City can't Empty !")]
        public string City { get; set; }
        [Display(Name = "Employee Email")]
        [Required(ErrorMessage = "Employee Email can't Empty !")]
        public string Email { get; set; }
        [Display(Name = "Employee Adhar_no")]
        [Required(ErrorMessage = "Employee Adhar_no can't Empty !")]
        public string Adhar_no { get; set; }
    }
}
