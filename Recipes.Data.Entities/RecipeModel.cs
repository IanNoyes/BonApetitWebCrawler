using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Recipes.Data.Entities {
    public class Recipe {
        public int RecipeId { get; set; }
        public string UniqueId { get; set; }
        public string RecipeName { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}