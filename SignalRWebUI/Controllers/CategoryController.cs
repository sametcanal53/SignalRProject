using SignalRWebUI.Dtos.Concretes.Category;

namespace SignalRWebUI.Controllers
{
    public class CategoryController : BaseController<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
