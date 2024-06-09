using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Create;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Model;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class MenuTablesController : GenericController<MenuTable, GetMenuTableDto, CreateMenuTableDto, UpdateMenuTableDto>
    {
        public MenuTablesController(IMenuTableService menuTableService, IMapper mapper) : base(menuTableService, mapper)
        {
        }
    }
}
