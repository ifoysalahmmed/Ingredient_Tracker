using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IngredientTracker.Models;
using System.Data.Entity;

namespace IngredientTracker.DataContent
{
    public class DBIngredientTracker:DbContext
    {
        //manager_registration
        public DbSet<ManagerRegistration> ManagerRegistrations { get; set; }
        //ingredient
        public DbSet<Ingredient> Ingredients { get; set; }
        //chef_registration
        public DbSet<ChefRegistration> ChefRegistrations { get; set; }
        //recipe
        public DbSet<Recipe> Recipes { get; set; }


    }
}