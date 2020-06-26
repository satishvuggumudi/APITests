using Newtonsoft.Json;

namespace ApiServices.Models.Responce
{
    public class AlbumsResponseBodyModel
    {

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
