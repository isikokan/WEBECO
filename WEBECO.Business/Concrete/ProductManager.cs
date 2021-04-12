using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Business.Abstract;
using WEBECO.DataAccess.Abstract;
using WEBECO.Entities.Concrete;

namespace WEBECO.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        List<Product> IProductService.GetAll()
        {
            return _productDal.GetAll();
        }

        Product IProductService.GetById(int id)
        {
            return _productDal.Get(p => p.Id == id);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
    }
}
