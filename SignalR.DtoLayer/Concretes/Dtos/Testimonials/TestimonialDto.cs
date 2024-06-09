using SignalR.Core.Concretes;

namespace SignalR.DtoLayer.Concretes.Dtos.Testimonials
{
    public class TestimonialDto : Dto
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
