using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Category
{
    public class UpdateCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
