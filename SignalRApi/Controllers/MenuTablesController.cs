﻿using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTableDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class MenuTablesController : GenericController<MenuTable, ResultMenuTableDto, GetMenuTableDto, CreateMenuTableDto, UpdateMenuTableDto>
    {
        public MenuTablesController(IMenuTableService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}