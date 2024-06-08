using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstracts;
using SignalR.DataAccessLayer.Concretes;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly SignalRContext _context;
        public EfProductDal(SignalRContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> GetProductsWithCategories() => _context.Products.Include(p => p.Category).ToList();
        public int ProductCountByCategoryName(string categoryName) => _context.Products.Include(p => p.Category).Where(x => string.IsNullOrWhiteSpace(categoryName) || x.Category.Name == categoryName).Count();
        public decimal ProductPriceAvg(int? categoryId) => _context.Products.Where(p => !categoryId.HasValue || p.CategoryId == categoryId).Average(p => p.Price);
        public string ProductNameByMaxPrice(int? categoryId) => _context.Products.Where(p => !categoryId.HasValue || p.CategoryId == categoryId).OrderByDescending(p => p.Price).Select(p => p.Name).FirstOrDefault();
        public string ProductNameByMinPrice(int? categoryId) => _context.Products.Where(p => !categoryId.HasValue || p.CategoryId == categoryId).OrderBy(p => p.Price).Select(p => p.Name).FirstOrDefault();
    }
}
