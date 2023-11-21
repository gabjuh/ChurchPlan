using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchPlan
{
    public class SongApi
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("verses")]
        public List<string> Verses { get; set; }

        public string NumberAsString
        {
            get
            {
                return Number.ToString();
            }
        }
    }
}
