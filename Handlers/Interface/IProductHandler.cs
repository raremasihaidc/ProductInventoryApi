﻿using ProductsInventory.Model;

namespace ProductsInventory.Handlers.Interface
{
    public interface IProductHandler
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAll();
        Product GetById(int id);
    }
}
