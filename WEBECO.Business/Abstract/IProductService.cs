using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Entities.Concrete;

namespace WEBECO.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
