
using Domain.Entities.EntitiesMagento;
using Domain.Repositories.MagentoRepositories;
using MediatR;

namespace Application.Queries.QueriesMagento.GetOrdersMagento
{
    public class GetOrdersMagentoQueryHandler(IOrdersRepository ordersRepository) : IRequestHandler<GetOrdersMagentoQuery, List<Item>>
    {
        public async Task<List<Item>> Handle(GetOrdersMagentoQuery request, CancellationToken cancellationToken)
        {
            return await ordersRepository.GetAllOrdersAsync();
        }
    }
}