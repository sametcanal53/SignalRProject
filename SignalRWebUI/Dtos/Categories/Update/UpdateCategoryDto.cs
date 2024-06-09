using SignalR.Core.Abstracts;

namespace SignalRWebUI.Dtos.Categories.Update
{
    public class UpdateCategoryDto : CategoryDto, IDto<int>
    {
        public int Id { get; set; }
    }
}
