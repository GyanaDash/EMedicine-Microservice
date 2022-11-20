namespace EMedicine_Microservice.Models
{
    public class OrderItems
    {
        public int ID { get; set; }
        public int OrderId { get; set; }
        public int MedicineId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Discount { get; set; }
        public int Quantity { get; set; }
        public decimal Totalprice { get; set; }
    }
}
