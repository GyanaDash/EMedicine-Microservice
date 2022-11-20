namespace EMedicine_Microservice.Models
{
    public class Medicines
    {
        public int ID { get; set; }
        public string Manufacture { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpDate { get; set; }
        public string ImageUrl { get; set; }
        public int Status { get; set; }
    }
}
