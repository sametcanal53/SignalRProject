using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Testimonials.Update
{
    public class UpdateTestimonialDto : TestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
