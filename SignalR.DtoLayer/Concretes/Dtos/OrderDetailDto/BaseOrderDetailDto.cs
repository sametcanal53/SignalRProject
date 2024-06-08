namespace SignalR.DtoLayer.Concretes.Dtos.OrderDetailDto
{
    public class BaseOrderDetailDto
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
