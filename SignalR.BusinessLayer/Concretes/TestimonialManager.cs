using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class TestimonialManager : GenericManager<Testimonial>, ITestimonialService
    {
        public TestimonialManager(ITestimonialDal testimonialDal) : base(testimonialDal)
        {
        }
    }
}
