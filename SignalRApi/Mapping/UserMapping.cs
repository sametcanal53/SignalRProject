using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Users;
using SignalR.DtoLayer.Concretes.Dtos.Users.Create;
using SignalR.DtoLayer.Concretes.Dtos.Users.Model;
using SignalR.DtoLayer.Concretes.Dtos.Users.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
        }
    }
}
