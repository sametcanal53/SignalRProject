using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.TestimonialDto
{
    public class ResultTestimonialDto : BaseTestimonialDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
