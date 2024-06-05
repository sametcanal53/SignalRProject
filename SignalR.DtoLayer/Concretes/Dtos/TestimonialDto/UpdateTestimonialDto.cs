using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.TestimonialDto
{
    public class UpdateTestimonialDto : BaseTestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
