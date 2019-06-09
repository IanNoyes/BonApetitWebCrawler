using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recipes.Data.Entities {
    public class Recipe {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int RecipeId { get; set; }
        public string UniqueId { get; set; }
        public string RecipeName { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}