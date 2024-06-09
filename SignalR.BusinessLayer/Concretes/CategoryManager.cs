using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class CategoryManager : GenericManager<Category>, ICategoryService
    {
        public CategoryManager(ICategoryDal categoryDal) : base(categoryDal)
        {
        }
    }
}
