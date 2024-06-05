using SignalR.DtoLayer.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.CategoryDto
{
    public class GetCategoryDto : BaseCategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
