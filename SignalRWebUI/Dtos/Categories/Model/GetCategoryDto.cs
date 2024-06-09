using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Categories.Model
{
    public class GetCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
