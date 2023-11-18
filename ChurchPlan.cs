using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace ChurchPlan
{
    public class ChurchPlan
    {
        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("songs")]
        public List<Song> Songs { get; set; }

        [JsonPropertyName("birthdaySong")]
        public bool BirthdaySong { get; set; }
    }
}
