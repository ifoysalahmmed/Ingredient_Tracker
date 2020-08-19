using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IngredientTracker.Models
{
    public class ManagerRegistration
    {
        [Key]
        public int ManagerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Remote("IsUNameExits", "Accounts", ErrorMessage = "Username Already Exits!")]
        [Display(Name= "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [StringLength(14, MinimumLength = 11, ErrorMessage = "Invalid Phone Number")]
        [Remote("IsPhoneExits", "Accounts", ErrorMessage = "Phone Number Already Exits!")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Invalid Email")]
        [Remote("IsEmailExits", "Accounts", ErrorMessage = "Email Already Exits!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "Password Minimum Length is 8 and Maximum Length is 25")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Repeat Password is required")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password Dosen't Match")]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat Password")]
        public string RepeatPassword { get; set; }

    }
}