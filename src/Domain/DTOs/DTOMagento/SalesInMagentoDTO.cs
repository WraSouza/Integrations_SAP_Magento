

using Domain.Entities.EntitiesMagento;

namespace Domain.DTOs.DTOMagento
{
    public class SalesInMagentoDTO
    {
         public List<Item>? items { get; set; }
        public SearchCriteria? search_criteria { get; set; }
        public int total_count { get; set; }
    }
}