using Newtonsoft.Json;

namespace Domain.Entities.Response
{
    public class LoginResponse
    {
        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; } = string.Empty;
        public string SessionId { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public int SessionTimeout { get; set; }
    }
}