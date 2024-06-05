using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.DiscountDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : GenericController<Discount, ResultDiscountDto, GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IGenericService<Discount> service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
