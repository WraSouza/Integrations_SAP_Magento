using Domain.DTOs.DTOSAP;
using Domain.Entities.EntitiesSAP;

namespace Domain.Repositories.SAPRepositories
{
    public interface IBusinessPartnerRepository
    {
        Task<BusinessPartnerDTO> CreateBusinessPartnerAsync(BusinessPartner businessPartner);
        Task<BusinessPartnerDTO> GetAllBusinessPartnerAsync();
        Task<bool> VerifyIfBusinessPartnerExistsAsync(string cpf);
    }
}