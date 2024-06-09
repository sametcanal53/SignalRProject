using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Create;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Model;
using SignalR.DtoLayer.Concretes.Dtos.Discounts.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class DiscountController : GenericController<Discount, GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IDiscountService discountService, IMapper mapper) : base(discountService, mapper)
        {
        }
    }
}
