using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
{
    public class ResultTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
