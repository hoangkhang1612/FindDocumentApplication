using Newtonsoft.Json;

namespace FindActress.Models
{
    public class Actress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("japanName")]
        public string JapanName { get; set; }

        [JsonProperty("bust")]
        public int? Bust { get; set; }

        [JsonProperty("waist")]
        public int? Waist { get; set; }

        [JsonProperty("hip")]
        public int? Hip { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }
    }
}
