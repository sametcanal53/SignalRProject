using SignalRWebUI.Dtos.Categories.Create;
using SignalRWebUI.Dtos.Categories.Model;
using SignalRWebUI.Dtos.Categories.Update;

namespace SignalRWebUI.Controllers
{
    public class CategoryController : GenericController<GetCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
