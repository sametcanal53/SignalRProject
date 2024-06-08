using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
{
    public class UpdateTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
