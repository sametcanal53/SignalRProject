using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
{
    public class GetTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
