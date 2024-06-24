using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Roles;
using SignalR.DtoLayer.Concretes.Dtos.Roles.Create;
using SignalR.DtoLayer.Concretes.Dtos.Roles.Model;
using SignalR.DtoLayer.Concretes.Dtos.Roles.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class RoleMapping : Profile
    {
        public RoleMapping()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Role, GetRoleDto>().ReverseMap();
            CreateMap<Role, CreateRoleDto>().ReverseMap();
            CreateMap<Role, UpdateRoleDto>().ReverseMap();
        }
    }
}
