using System;
using ScrapySharp.Network;
using System.Linq;
using ScrapySharp.Extensions;

namespace Process.bonApetitCrawler
{
    class Program
    {
        public static string BaseURL {get; set;} 
        static void Main(string[] args)
        {
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
                    System.Console.WriteLine(recipe.InnerHtml);
                    System.Console.WriteLine(recipe.Attributes["href"].Value);
                }

                System.Console.WriteLine("Done reading Recipes, press any key to close");
                System.Console.ReadLine();

                //loop through the recipe urls

                //create a recipe model from each url

                //Console.WriteLine each recipe name and a couple things
        }
    }
}
