using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MoneyCaseDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class MoneyCaseController : GenericController<MoneyCase, ResultMoneyCaseDto, GetMoneyCaseDto, CreateMoneyCaseDto, UpdateMoneyCaseDto>
    {
        private readonly IMoneyCaseService _service;
        public MoneyCaseController(IMoneyCaseService service, IMapper mapper) : base(service, mapper)
        {
            _service = service;
        }

        [HttpGet("TotalMoneyCaseAmount")]
        public IActionResult TotalMoneyCaseAmount(DateTime? date) => Ok(_service.TotalMoneyCaseAmount(date));
    }
}
