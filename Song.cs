using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace ChurchPlan
{
    public class Song
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("book")]
        public string Book { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("verses")]
        public List<int> Verses { get; set; }

        [JsonPropertyName("origString")]
        public string OrigString { get; set; }

        public string VersesToString { get 
            {
                string output = "";
                for (int i = 0; i < Verses.Count; i++)
                {
                    output += Verses[i].ToString();

                    if (i < Verses.Count - 1)
                    {
                        output += ", ";
                    }
                }
                return output;
            }
        }
    }
}
