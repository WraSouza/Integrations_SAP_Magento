

namespace Domain.Entities.EntitiesSAP
{
    public class BusinessPartnerResponse
    {
        public BusinessPartnerResponse(BusinessPartner? businessPartners, BusinessPartnerFiscalTaxIDCollection? businessPartnersBPFiscalTaxIDCollection, BusinessPartnerAddress? businessPartnersBPAddresses)
        {
            BusinessPartners = businessPartners;
            BusinessPartnersBPFiscalTaxIDCollection = businessPartnersBPFiscalTaxIDCollection;
            BusinessPartnersBPAddresses = businessPartnersBPAddresses;
        }

        public BusinessPartner? BusinessPartners { get; set; }
        public BusinessPartnerFiscalTaxIDCollection? BusinessPartnersBPFiscalTaxIDCollection { get; set; }
        public BusinessPartnerAddress? BusinessPartnersBPAddresses { get; set; }
    }
}