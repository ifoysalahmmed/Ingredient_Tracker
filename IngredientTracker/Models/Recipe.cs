using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IngredientTracker.Models
{
    public class Recipe
    {
        [Key]
        public int RecipeId { get; set; }

        [Required(ErrorMessage = "Recipe name is required")]
        public string RecipeName { get; set; }

        [Required(ErrorMessage = "Recipe description is required")]
        public string RecipeDescription { get; set; }
        //public int NoOfRows { get; set; }
        //public IEnumerable<Ingredient> IngredientList { get; set; }
    }
}