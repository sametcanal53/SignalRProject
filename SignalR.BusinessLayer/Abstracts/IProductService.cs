﻿using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Abstracts
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> GetProductsWithCategories();
        int ProductCountByCategoryName(string categoryName);
        decimal ProductPriceAvg(int? categoryId = default);
        string ProductNameByMaxPrice(int? categoryId = default);
        string ProductNameByMinPrice(int? categoryId = default);
    }
}
