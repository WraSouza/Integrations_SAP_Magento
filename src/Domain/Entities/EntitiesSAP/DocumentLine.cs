
namespace Domain.Entities.EntitiesSAP
{
    public class DocumentLine
    {        
            public DocumentLine(string itemCode,  double quantity, double price)
            {
                ItemCode = itemCode;                
                Quantity = quantity;
                Price = price;                
                WarehouseCode = "TJPA";                
                Usage = 15;
                Confirmed = "tNO";
            }

        public string ItemCode { get; set; } = string.Empty;
        public string Confirmed { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public string WarehouseCode { get; set; } = string.Empty;                 
        public string? BarCode { get; set; }      
        public string TaxCode { get; set; } = string.Empty;        
        public int Usage { get; private set; }    
    }
}