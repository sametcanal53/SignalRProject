using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Create;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Model;
using SignalR.DtoLayer.Concretes.Dtos.MenuTables.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class MenuTableMapping : Profile
    {
        public MenuTableMapping()
        {
            CreateMap<MenuTable, MenuTableDto>().ReverseMap();
            CreateMap<MenuTable, GetMenuTableDto>().ReverseMap();
            CreateMap<MenuTable, CreateMenuTableDto>().ReverseMap();
            CreateMap<MenuTable, UpdateMenuTableDto>().ReverseMap();
        }
    }
}
