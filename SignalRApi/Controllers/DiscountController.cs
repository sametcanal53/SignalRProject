using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class DiscountController : GenericController<Discount, ResultDiscountDto, GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IDiscountService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
