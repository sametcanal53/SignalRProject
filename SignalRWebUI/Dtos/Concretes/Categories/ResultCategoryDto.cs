using SignalRWebUI.Dtos.Abstracts;

namespace SignalRWebUI.Dtos.Concretes.Category
{
    public class ResultCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
