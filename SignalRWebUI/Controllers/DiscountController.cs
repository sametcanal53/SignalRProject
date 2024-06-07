using SignalRWebUI.Dtos.Concretes.Discounts;

namespace SignalRWebUI.Controllers
{
    public class DiscountController : BaseController<ResultDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
