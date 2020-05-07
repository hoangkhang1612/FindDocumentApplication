using System;
using Newtonsoft.Json;

namespace FindActress.Models
{
    public class Movie
    {
        //[JsonProperty("siteUrl")]
        //public string SiteUrl { get; set; }

        [JsonIgnore]
        public string Code
        {
            get
            {
                //cid=
                var c = SiteUrl.Split(new string[] { "/cid=" }, StringSplitOptions.RemoveEmptyEntries);
                if (c.Length >= 2)
                {
                    var c2 = c[1].Split('/');

                    return c2[0];
                }

                return "no code!";
            }
        }

        //[JsonProperty("date")]
        //public string Date { get; set; }


        //[JsonProperty("name")]
        //public string Name { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("siteUrl")]
        public string SiteUrl { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        //[JsonProperty("maker")]
        //public Maker[] Maker { get; set; }

        //[JsonProperty("review")]
        //public Review Review { get; set; }

        //[JsonProperty("actress")]
        //public Actress[] Actress { get; set; }
    }
}
