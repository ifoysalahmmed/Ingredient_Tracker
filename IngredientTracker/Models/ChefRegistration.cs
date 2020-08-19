using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IngredientTracker.Models
{
    public class ChefRegistration
    {
        [Key]
        public int ChefID { get; set; }
                
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        [Remote("IsUNameExits", "Managers", ErrorMessage = "User Name Already Exits!")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(25, MinimumLength = 8, ErrorMessage = "Password Minimum Length is 8 and Maximum Length is 25")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}