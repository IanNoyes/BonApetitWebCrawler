using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Recipes.Data.Entities {
    public class RecipeContext : DbContext {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL ("server=localhost;database=Recipe;user=dev;password=dev");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            base.OnModelCreating (modelBuilder);

            modelBuilder.Entity<Recipe> (entity => {
                entity.HasKey (e => e.RecipeId);
                // entity.Property (e => e.UniqueId)
                //     .HasDefaultValueSql ("newid()");
            });

            modelBuilder.Entity<Ingredient> (entity => {
                entity.HasKey (e => e.IngredientId);
            });
        }
    }
}