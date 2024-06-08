using SignalRWebUI.Dtos.Concretes.Testimonials;

namespace SignalRWebUI.Controllers
{
    public class TestimonialController : GenericController<ResultTestimonialDto, CreateTestimonialDto, UpdateTestimonialDto>
    {
        public TestimonialController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
