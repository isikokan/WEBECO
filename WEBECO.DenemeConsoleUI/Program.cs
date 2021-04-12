using System;
using System.Collections.Generic;
using WEBECO.Business.Abstract;
using WEBECO.Business.Concrete;
using WEBECO.DataAccess.Concrete.EntityFramework;
using WEBECO.Entities.Concrete;

namespace WEBECO.DenemeConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new EfProductDal());
            List<Product> products = productService.GetAll();

            ICategoryService categoryService = new CategoryManager(new EfCategoryDal());
            List<Category> categories = categoryService.GetAll();

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}
