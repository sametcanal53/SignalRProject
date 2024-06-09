using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Testimonials.Model
{
    public class GetTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
