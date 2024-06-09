using SignalRWebUI.Dtos.Testimonials.Create;
using SignalRWebUI.Dtos.Testimonials.Model;
using SignalRWebUI.Dtos.Testimonials.Update;

namespace SignalRWebUI.Controllers
{
    public class TestimonialController : GenericController<GetTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
