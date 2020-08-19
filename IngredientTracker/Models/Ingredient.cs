using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IngredientTracker.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required(ErrorMessage = "Ingredinet name is required")]
        public string IngredientName { get; set; }

        [Required(ErrorMessage = "Ingredinet amount is required")]
        public double IngredientAmount { get; set; }

        [Required(ErrorMessage = "Ingredinet unit is required")]
        public string Unit { get; set; }
    }
}