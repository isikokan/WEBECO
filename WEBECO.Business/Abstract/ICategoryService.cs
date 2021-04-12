using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Entities.Concrete;

namespace WEBECO.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Add(Category product);
        void Update(Category product);
        void Delete(Category product);
    }
}
