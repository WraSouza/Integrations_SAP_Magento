

using Domain.Entities.EntitiesSAP;
using Newtonsoft.Json;

namespace Domain.DTOs.DTOSAP
{
    public class BusinessPartnerDTO
    {
        public BusinessPartnerDTO(string odatametadata, List<Value>? value, string odatanextLink)
        {
            this.odatametadata = odatametadata;
            this.value = value;
            this.odatanextLink = odatanextLink;
        }

        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; } = string.Empty;
        public List<Value>? value { get; set; }

        [JsonProperty("odata.nextLink")]
        public string odatanextLink { get; set; } = string.Empty;
    }   

    public class Value
    {
        public string CardCode { get; set; } = string.Empty;
        public string CardName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Phone1 { get; set; } = string.Empty;     
        public string City { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;    
        public string Block { get; set; } = string.Empty;        
       // public List<BusinessPartnerAddress>? BPAddresses { get; set; }
       
    } 
}