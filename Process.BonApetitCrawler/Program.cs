using System;
using System.Linq;
using Recipes.Data.Entities;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace Process.bonApetitCrawler {
    class Program {
        public static string BaseURL { get; set; }
        static void Main (string[] args) {
            using (var context = new RecipeContext ()) {
                context.Database.EnsureCreated ();
            }

            BaseURL = "https://www.bonappetit.com/";
            //Go to The Recipes page
            ScrapingBrowser browser = new ScrapingBrowser ();

            //set UseDefaultCookiesParser as false if a website returns invalid cookies format
            //browser.UseDefaultCookiesParser = false;

            WebPage recipesPage = browser.NavigateToPage (new Uri (BaseURL + "recipes"));

            //Create a process for grabbing recipe urls
            var recipeCards = recipesPage.Html.CssSelect (".card-hed a").ToList ();
            foreach (var recipe in recipeCards) {
                WebPage recipePage = browser.NavigateToPage (new Uri (BaseURL + recipe.Attributes["href"].Value));
                var html = recipePage.Html;
                var name = html.CssSelect ("h1.post__header__hed a").FirstOrDefault ().InnerHtml;
                var ingredients = html.CssSelect ("li.ingredient div").ToList ();
                System.Console.WriteLine (name);
                foreach (var ingredient in ingredients) {
                    System.Console.WriteLine (ingredient.InnerHtml);
                }

            }

            System.Console.WriteLine ("Done reading Recipes, press any key to close");
            System.Console.ReadLine ();

            //loop through the recipe urls

            //create a recipe model from each url

            //Console.WriteLine each recipe name and a couple things
        }
    }
}