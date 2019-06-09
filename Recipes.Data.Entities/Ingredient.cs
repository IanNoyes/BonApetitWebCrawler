using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Recipes.Data.Entities {

    public class Ingredient {
        [Key]
        [DatabaseGenerated (DatabaseGeneratedOption.Identity)]
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }

        [ForeignKey ("RecipeForeignKey")]
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        // public int IngredientCategoryId { get; set; }
    }

}