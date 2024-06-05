using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.CategoryDto
{
    public class UpdateCategoryDto : BaseCategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
