namespace OrderSalesApp.Shared.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public required string OrderName { get; set; }
        public required string State { get; set; }
        public required string WindowName { get; set; }
        public int Qty { get; set; }
        public int TotalProducts { get; set; }
        public int ProductId { get; set; }
        public required string ProductName { get; set; }
        public  required string Type { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }


    }
}
