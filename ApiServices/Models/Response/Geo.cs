using Newtonsoft.Json;

namespace ApiServices.Models.Responce
{
    public class Geo
    {
        [JsonProperty("lat")]
        public string Lat { get; set; }

        [JsonProperty("lng")]
        public string Lng { get; set; }
    }
}
