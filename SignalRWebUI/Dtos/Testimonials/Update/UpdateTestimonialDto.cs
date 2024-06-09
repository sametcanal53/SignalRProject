using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Testimonials.Update
{
    public class UpdateTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
