using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Testimonials.Model
{
    public class GetTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
