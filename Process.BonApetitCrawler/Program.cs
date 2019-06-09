using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Recipes.Data.Entities;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace Process.bonApetitCrawler
{
    class Program
    {
        public static string BaseURL { get; set; }
        static void Main(string[] args)
        {
            using (var context = new RecipeContext())
            {
                context.Database.EnsureCreated();
            }
            //TODO: Map Recipe To DB with Ingredients
            //TODO: After each recipe go to the next page in the recipes
            BaseURL = "https://www.bonappetit.com/";
            //Go to The Recipes page
            ScrapingBrowser browser = new ScrapingBrowser();

            //set UseDefaultCookiesParser as false if a website returns invalid cookies format
            //browser.UseDefaultCookiesParser = false;

            WebPage recipesPage = browser.NavigateToPage(new Uri(BaseURL + "recipes"));

            //Create a process for grabbing recipe urls
            var recipeCards = recipesPage.Html.CssSelect(".card-hed a").ToList();
            foreach (var recipe in recipeCards)
            {
                MapRecipe(recipe, browser);
            }

            System.Console.WriteLine("Done reading Recipes, press any key to close");
            System.Console.ReadLine();

        }
        public static void MapRecipe(HtmlAgilityPack.HtmlNode recipe, ScrapingBrowser browser)
        {
            using (var context = new RecipeContext())
            {

                WebPage recipePage = browser.NavigateToPage(new Uri(BaseURL + recipe.Attributes["href"].Value));
                var html = recipePage.Html;
                var name = html.CssSelect("h1.post__header__hed a").FirstOrDefault().InnerHtml;
                var result = context.Recipes.FirstOrDefault(x => x.RecipeName == name);
                if (result == null)
                {
                    result = new Recipe();
                    result.RecipeName = name;
                    context.Recipes.Add(result);
                    result.Ingredients = new List<Ingredient>();
                }
                var ingredients = html.CssSelect("li.ingredient div").ToList();
                System.Console.WriteLine(name);
                foreach (var ingredientHtml in ingredients)
                {
                    if (context.Ingredients.Any(x => x.IngredientName == ingredientHtml.InnerHtml) == false && result.Ingredients.Any(x => x.IngredientName == ingredientHtml.InnerHtml))
                    {
                        result.Ingredients.Add(MapIngredient(ingredientHtml));
                    }
                }
                context.SaveChanges();
            }
        }

        public static Ingredient MapIngredient(HtmlAgilityPack.HtmlNode ingredient)
        {
            var result = new Ingredient();
            result.IngredientName = ingredient.InnerHtml;
            return result;

        }
    }
}