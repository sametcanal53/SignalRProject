using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.TestimonialDto
{
    public class GetTestimonialDto : BaseTestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
