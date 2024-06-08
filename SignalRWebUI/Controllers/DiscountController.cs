using SignalRWebUI.Dtos.Concretes.Discounts;

namespace SignalRWebUI.Controllers
{
    public class DiscountController : GenericController<ResultDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
