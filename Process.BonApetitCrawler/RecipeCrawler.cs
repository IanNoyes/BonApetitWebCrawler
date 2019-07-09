using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using Process.BonApetitCrawler.Models;

namespace Process.BonApetitCrawler {
    //Use this to keep track of our crawl status and send requests and parse responses
    public class RecipeCrawler {
        public int page { get; set; }
        private static readonly HttpClient Client = new HttpClient ();
        public async System.Threading.Tasks.Task<string> GetRecipeResponseAsync () {
            WebRequest request = WebRequest.Create ("https://www.bonappetit.com/api/bundles");
            request.Method = "POST";
            request.ContentType = "application/json";

            var postData = new Dictionary<string, string> () { { "contentType", "recipeChannel" }, { "page", page.ToString () }, { "url", "/bundles/59d6af2dcd8bb1736b3fdbde/revisions/26/containers/59d6af2dcd8bb1736b3fdbdc/items?page=" + page.ToString () }
                };

            var content = new FormUrlEncodedContent (postData);

            var response = await Client.PostAsync ("https://www.bonappetit.com/api/bundles", content);

            //send out request and get our response
            var responseString = await response.Content.ReadAsStringAsync ();

            return responseString;
        }

        public BAResponseModel Parseresponse (string json) {
            var decoded = HttpUtility.HtmlDecode (json);
            var res = JsonConvert.DeserializeObject<BAResponseModel> (json);
            return res;
        }
    }
}