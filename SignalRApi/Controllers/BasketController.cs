using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Create;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.ControllerRequest;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Model;
using SignalR.DtoLayer.Concretes.Dtos.Baskets.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class BasketController : GenericController<Basket, GetBasketDto, CreateBasketDto, UpdateBasketDto>
    {
        private readonly IBasketService _basketService;
        private readonly IMapper _mapper;
        public BasketController(IBasketService basketService, IMapper mapper) : base(basketService, mapper)
        {
            _basketService = basketService;
            _mapper = mapper;
        }

        [HttpGet("GetBasketByMenuTableNumber")]
        public IActionResult GetBasketByMenuTableNumber(GetBasketByMenuTableNumberRequest request) => Ok(_mapper.Map<List<GetBasketDto>>(_basketService.GetBasketByMenuTableNumber(request.MenuTableId)));

    }
}
