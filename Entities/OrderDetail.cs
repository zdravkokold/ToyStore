namespace ToyStore.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ToyId { get; set; }
        public Toy Toy { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}