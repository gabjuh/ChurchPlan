using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ChurchPlan
{
    public class Root
    {
        [JsonPropertyName("churchPlans")]
        public List<ChurchPlan> ChurchPlans { get; set; }

        public static Root? GetJsonData()
        {
            string filename = @"..\..\..\res\data.json";

            string jsonString = File.ReadAllText(filename);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            Root data = JsonSerializer.Deserialize<Root>(jsonString, options);

            foreach (var item in data.ChurchPlans)
            {
                Debug.WriteLine(item.Date);
            }

            return data;
        }
    }

    
}
