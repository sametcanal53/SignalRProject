using Microsoft.AspNetCore.Mvc;
using SignalRWebUI.Dtos.Baskets.Create;
using SignalRWebUI.Dtos.Baskets.Model;
using SignalRWebUI.Dtos.Baskets.Update;

namespace SignalRWebUI.Controllers
{
    public class BasketController : GenericController<GetBasketDto, CreateBasketDto, UpdateBasketDto>
    {
        public BasketController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
