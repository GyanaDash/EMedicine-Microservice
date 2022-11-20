namespace EMedicine_Microservice.Models
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int MedicineId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
