using System.Collections.Generic;
using Newtonsoft.Json;

namespace FindActress.Models
{
    public class ActressResult<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public IEnumerable<Actress> Result { get; set; }
    }
}
