using SignalRWebUI.Dtos.Concretes.Category;

namespace SignalRWebUI.Controllers
{
    public class CategoryController : GenericController<ResultCategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        public CategoryController(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }
    }
}
