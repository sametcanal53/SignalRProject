using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.CategoryDto
{
    public class ResultCategoryDto : BaseCategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
