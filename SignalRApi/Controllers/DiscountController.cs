using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : GenericController<Discount, IDiscountService, ResultDiscountDto, GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IDiscountService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
