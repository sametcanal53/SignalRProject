using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : GenericController<Testimonial, ITestimonialService, ResultTestimonialDto, GetTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(ITestimonialService service, IMapper mapper) : base(service, mapper)
        {
        }
    }
}
