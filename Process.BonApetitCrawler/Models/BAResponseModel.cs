using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Process.BonApetitCrawler.Models
{
    public class BAResponseModel
    {
        [JsonProperty("items")]
        public ItemModel[] Items { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }
}