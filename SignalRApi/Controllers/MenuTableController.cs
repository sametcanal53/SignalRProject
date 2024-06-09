using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Create;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Model;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class MenuTableController : GenericController<MenuTable, GetMenuTableDto, CreateMenuTableDto, UpdateMenuTableDto>
    {
        public MenuTableController(IMenuTableService menuTableService, IMapper mapper) : base(menuTableService, mapper)
        {
        }
    }
}
