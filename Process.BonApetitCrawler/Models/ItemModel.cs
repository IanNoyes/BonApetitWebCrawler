using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Process.BonApetitCrawler.Models
{
    public class ItemModel
    {

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("canonicalUrl")]
        public string CanonicalUrl { get; set; }

        [JsonProperty("contentSource")]
        public string ContentSource { get; set; }

        [JsonProperty("dek")]
        public string Dek { get; set; }

        [JsonProperty("hed")]
        public string Hed { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("promoDek")]
        public string PromoDek { get; set; }

        [JsonProperty("promoHed")]
        public string PromoHed { get; set; }

        [JsonProperty("seoDescription")]
        public string SeoDescription { get; set; }

        [JsonProperty("seoTitle")]
        public string SeoTitle { get; set; }

        [JsonProperty("socialDescription")]
        public string SocialDescription { get; set; }

        [JsonProperty("socialTitle")]
        public string SocialTitle { get; set; }

        [JsonProperty("subChannel")]
        public string SubChannel { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("nutritionalInfo")]
        public string NutritionalInfo { get; set; }

        // [JsonProperty("temperatures")]
        // public Temperatures Temperatures { get; set; }

        // [JsonProperty("times")]
        // public InlineEmbeds Times { get; set; }

        // [JsonProperty("servingSizeInfo")]
        // public ServingSizeInfo ServingSizeInfo { get; set; }

        [JsonProperty("prepNotes")]
        public string PrepNotes { get; set; }

        [JsonProperty("prepNotesHed")]
        public string PrepNotesHed { get; set; }

        [JsonProperty("byline")]
        public string Byline { get; set; }

        [JsonProperty("primaryChannel")]
        public string PrimaryChannel { get; set; }

        [JsonProperty("legacyId")]
        public long LegacyId { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("amgUserId")]
        public string AmgUserId { get; set; }

        [JsonProperty("isPublic")]
        public bool IsPublic { get; set; }

        [JsonProperty("restaurant")]
        public string Restaurant { get; set; }

        [JsonProperty("issueMonth")]
        public string IssueMonth { get; set; }

        [JsonProperty("issueYear")]
        public long IssueYear { get; set; }

        [JsonProperty("aggregateRating")]
        public long AggregateRating { get; set; }

        [JsonProperty("willMakeAgainPct")]
        public long WillMakeAgainPct { get; set; }

        [JsonProperty("revisionAuthor")]
        public string RevisionAuthor { get; set; }

        // [JsonProperty("ingredientGroups")]
        // public IngredientGroup[] IngredientGroups { get; set; }

        // [JsonProperty("preparationGroups")]
        // public PreparationGroup[] PreparationGroups { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        //     // [JsonProperty("meta")]
        //     // public Meta Meta { get; set; }

        //     // [JsonProperty("channel")]
        //     // public Channel Channel { get; set; }

        //     [JsonProperty("displayCopyright")]
        //     public string DisplayCopyright { get; set; }

        //     [JsonProperty("copyright")]
        //     public string Copyright { get; set; }

        //     [JsonProperty("cookbookSource")]
        //     public string CookbookSource { get; set; }

        //     [JsonProperty("id")]
        //     public string Id { get; set; }

        //     [JsonProperty("revision")]
        //     public long Revision { get; set; }

        //     [JsonProperty("createdAt")]
        //     public string CreatedAt { get; set; }

        //     [JsonProperty("modifiedAt")]
        //     public string ModifiedAt { get; set; }

        //     [JsonProperty("revisionCreatedAt")]
        //     public string RevisionCreatedAt { get; set; }

        //     [JsonProperty("organizationId")]
        //     public OrganizationId OrganizationId { get; set; }

        //     [JsonProperty("_links")]
        //     public Links Links { get; set; }

        //     [JsonProperty("_embedded")]
        //     public Embedded Embedded { get; set; }

        //     [JsonProperty("modelName")]
        //     public ModelName ModelName { get; set; }

        //     [JsonProperty("collection")]
        //     public Channel Collection { get; set; }

        //     [JsonProperty("contributors")]
        //     public Contributors Contributors { get; set; }

        //     [JsonProperty("cneTags")]
        //     public string[] CneTags { get; set; }

        //     [JsonProperty("inlineEmbeds")]
        //     public InlineEmbeds InlineEmbeds { get; set; }

        //     [JsonProperty("photos")]
        //     public PhotosClass Photos { get; set; }

        //     [JsonProperty("photoTout")]
        //     public PhotoTout PhotoTout { get; set; }

        //     [JsonProperty("products")]
        //     public object[] Products { get; set; }

        //     [JsonProperty("ingredientProducts")]
        //     public object[] IngredientProducts { get; set; }

        //     [JsonProperty("pubDate")]
        //     public string PubDate { get; set; }

        //     [JsonProperty("publishHistory")]
        //     public PublishHistory PublishHistory { get; set; }

        //     [JsonProperty("getPrepped")]
        //     public GetPrepped[][] GetPrepped { get; set; }

        //     [JsonProperty("getPreppedHeds")]
        //     public string[] GetPreppedHeds { get; set; }

        //     [JsonProperty("steps")]
        //     public GetPrepped[][] Steps { get; set; }

        //     [JsonProperty("taxonomies")]
        //     public FieldsElement[] Taxonomies { get; set; }

        //     [JsonProperty("template")]
        //     public Template Template { get; set; }

        //     [JsonProperty("rubric")]
        //     public Channel Rubric { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        //     [JsonProperty("relatedVideos")]
        //     public object[] RelatedVideos { get; set; }

        //     [JsonProperty("issueURL")]
        //     public string IssueUrl { get; set; }

        //     [JsonProperty("reviewsCount", NullValueHandling = NullValueHandling.Ignore)]
        //     public long? ReviewsCount { get; set; }
    }
}