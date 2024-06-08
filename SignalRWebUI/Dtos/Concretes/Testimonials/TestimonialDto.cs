using SignalRWebUI.Dtos.Concretes.Base;

namespace SignalRWebUI.Dtos.Concretes.Testimonials
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
