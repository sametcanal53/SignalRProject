using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Create;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Model;
using SignalR.DtoLayer.Concretes.Dtos.Testimonials.Update;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class TestimonialController : GenericController<Testimonial, GetTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(ITestimonialService testimonialService, IMapper mapper) : base(testimonialService, mapper)
        {
        }
    }
}
