using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class UpcomingResponse
    {
        [JsonProperty("results")]
        public List<Movie> Movies { get; set; }
    }
}
