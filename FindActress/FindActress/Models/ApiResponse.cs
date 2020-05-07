using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace FindActress.Models
{
    public class ApiResponse<T>
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("result")]
        public T Result { get; set; }
    }
}
