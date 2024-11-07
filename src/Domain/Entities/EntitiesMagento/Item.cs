

namespace Domain.Entities.EntitiesMagento
{
    public class Item
    {    
        public string status { get; set; } = string.Empty;
        public int total_qty_ordered { get; set; }
        public List<Item>? items { get; set; }
        public BillingAddress? billing_address { get; set; }
        public Payment? payment { get; set; }
        public double? total_paid { get; set; }
        public double base_price { get; set; }
        public double price { get; set; }
        public int qty_ordered { get; set; }
        public double row_invoiced { get; set; }
        public string sku { get; set; } = string.Empty;
       
    }
}