using Domain.Entities.EntitiesMagento;

namespace Domain.Repositories.MagentoRepositories
{
    public interface IOrdersRepository
    {
        Task<List<Item>> GetAllOrdersAsync();
    }
}