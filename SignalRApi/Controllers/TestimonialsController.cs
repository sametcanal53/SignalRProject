using AutoMapper;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    public class TestimonialsController : GenericController<Testimonial, ResultTestimonialDto, GetTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper) : base(testimonialService, mapper)
        {
        }
    }
}
