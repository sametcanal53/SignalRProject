using AutoMapper;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Create;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Model;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestimonialMapping : Profile
    {
        public TestimonialMapping()
        {
            CreateMap<Testimonial, TestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
        }
    }
}
