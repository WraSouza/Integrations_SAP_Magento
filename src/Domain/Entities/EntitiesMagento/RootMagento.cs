

namespace Domain.Entities.EntitiesMagento
{
    public class RootMagento
    {
        public List<Item>? items { get; set; }
        public SearchCriteria? search_criteria { get; set; }
        public int total_count { get; set; }
    }
}