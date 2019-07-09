using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Process.BonApetitCrawler;
using Xunit;

namespace Tests.BonApetitCrawler {
    //TODO: Crawl through each response
    //TODO: Determine what else we need to get from each response
    //TODO: Move to next page when all recipes are crawled
    public class BonApetitCrawlerTests {
        [Fact]
        public void ParseJsonResponseToModel () {
            //Assert.True(true);
            using (StreamReader r = new StreamReader ("TestJson.json")) {
                var crawler = new RecipeCrawler ();
                var json = r.ReadToEnd ();
                var obj = crawler.Parseresponse (json);

                var recipe = obj.Items.FirstOrDefault ();
                Assert.Equal (1, obj.Items.Count ());
                Assert.Equal ("Party Steak with Grilled Scallion Salsa Verde", recipe.Hed);
                Assert.Equal ("recipe/steak-with-grilled-scallion-salsa-verde", recipe.Url);
            }
        }
    }
}