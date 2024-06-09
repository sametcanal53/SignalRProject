using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Categories.Model
{
    public class GetCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
