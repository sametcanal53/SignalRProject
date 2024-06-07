using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
{
    public class UpdateTestimonialDto : BaseTestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
