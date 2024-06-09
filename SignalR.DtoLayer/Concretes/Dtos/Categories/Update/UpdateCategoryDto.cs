using SignalR.Core.Abstracts;

namespace SignalR.DtoLayer.Concretes.Dtos.Categories.Update
{
    public class UpdateCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
