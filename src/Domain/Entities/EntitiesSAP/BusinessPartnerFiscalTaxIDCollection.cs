

namespace Domain.Entities.EntitiesSAP
{
    public class BusinessPartnerFiscalTaxIDCollection
    {
           public BusinessPartnerFiscalTaxIDCollection(string taxId0, string taxId1, string taxId4)
            {
                TaxId0 = taxId0;
                TaxId1 = taxId1;               
                TaxId4 = taxId4;                
            }

        public string TaxId0 { get; set; } = string.Empty;
        public string TaxId1 { get; set; } = string.Empty;
        public string TaxId2 { get; set; } = string.Empty;
        public string TaxId3 { get; set; } = string.Empty;
        public string TaxId4 { get; set; } = string.Empty;       
        public string BPCode { get; set; } = string.Empty;
    }
}