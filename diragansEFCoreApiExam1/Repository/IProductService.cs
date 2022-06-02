﻿using diragansEFCoreApiExam1.Models;

namespace diragansEFCoreApiExam1.Repository
{
    public interface IProductService
    {
        Product GetProductByID(int ID);
        List<Product> GetAllProduct();
        Product AddProduct(Product p);

        Product UpdateProduct(Product p);
        void DeleteProduct(int ID);

    }
}
