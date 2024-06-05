using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstracts;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concretes
{
    public class ProductManager : GenericManager<Product>, IProductService
    {
        private readonly SignalRContext _context;
        public ProductManager(IGenericDal<Product> dal, SignalRContext context) : base(dal)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategories()
        {
            var result = _context.Products.Include(p => p.Category).ToList();
            return result;
        }
    }
}
