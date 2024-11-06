using Domain.DTOs.DTOSAP;
using Domain.Repositories.SAPRepositories;
using MediatR;

namespace Application.Queries.QueriesSAP.GetBusinessPartner
{
    public class GetBusinessPartnerQueryHandler(IBusinessPartnerRepository businessPartnerRepository) : IRequestHandler<GetBusinessPartnerQuery, BusinessPartnerDTO>
    {
        public Task<BusinessPartnerDTO> Handle(GetBusinessPartnerQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            return businessPartnerRepository.GetAllBusinessPartnerAsync();
        }
    }
}