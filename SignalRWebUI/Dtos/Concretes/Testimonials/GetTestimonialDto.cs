using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
{
    public class GetTestimonialDto : BaseTestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
