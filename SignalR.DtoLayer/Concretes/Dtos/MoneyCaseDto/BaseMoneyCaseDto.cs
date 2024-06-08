using SignalR.Enums;

namespace SignalR.DtoLayer.Concretes.Dtos.MoneyCaseDto
{
    public class BaseMoneyCaseDto
    {
        public string TableNumber { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalPrice { get; set; }
        public EnumOrderStatus Status { get; set; }
    }
}
