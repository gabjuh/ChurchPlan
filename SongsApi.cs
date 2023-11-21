using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChurchPlan
{
    public class SongsApi
    {
        [JsonPropertyName("songs")]
        public List<SongApi> AllSongs { get; set; }

        public static SongsApi? GetJsonData()
        {
            string filename = @"..\..\..\res\songs.json";

            string jsonString = File.ReadAllText(filename);

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
            };

            var data = JsonSerializer.Deserialize<SongsApi>(jsonString);

            return data;
        }

        public SongApi? GetSong(int songNumber)
        {
            // Find Song with number
            SongApi song = AllSongs.Find(s => s.Number == songNumber);

            return song;
        }
    }
}
