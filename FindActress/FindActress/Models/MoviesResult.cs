using System.Collections.Generic;
using Newtonsoft.Json;

namespace FindActress.Models
{
    public class MoviesResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public List<Movie> Result { get; set; }
    }
}
