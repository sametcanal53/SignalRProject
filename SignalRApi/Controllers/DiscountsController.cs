using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class DiscountsController : GenericController<Discount, ResultDiscountDto, GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountsController(IDiscountService discountService, IMapper mapper) : base(discountService, mapper)
        {
        }
    }
}
