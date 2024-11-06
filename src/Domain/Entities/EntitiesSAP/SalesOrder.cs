
namespace Domain.Entities.EntitiesSAP
{
    public class SalesOrder
    {        
        public SalesOrder(string cardCode,string numAtCard,  List<DocumentLine>? documentLines)
        {
            DocType = "dDocument_Items";
            DocDueDate = DateTime.Today;
            NumAtCard = numAtCard;
            CardCode = cardCode;               
            PaymentGroupCode = 45;                            
            DocumentLines = documentLines;
        }

        public int DocEntry { get; set; }
        public int DocNum { get; set; }
        public string DocType { get; set; } = string.Empty;
        public DateTime DocDueDate { get; set; }
        public string CardCode { get; set; } = string.Empty;
        public string CardName { get; set; } = string.Empty;    
        public string NumAtCard { get; set; }   
        public double DocTotal { get; set; }       
        public int PaymentGroupCode { get; set; }           
        public List<DocumentLine>? DocumentLines { get; set; }
    }
}