using SignalRWebUI.Dtos.Discounts.Create;
using SignalRWebUI.Dtos.Discounts.Model;
using SignalRWebUI.Dtos.Discounts.Update;

namespace SignalRWebUI.Controllers
{
    public class DiscountController : GenericController<GetDiscountDto, CreateDiscountDto, UpdateDiscountDto>
    {
        public DiscountController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
