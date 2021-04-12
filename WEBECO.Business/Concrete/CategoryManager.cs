using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Business.Abstract;
using WEBECO.DataAccess.Abstract;
using WEBECO.Entities.Concrete;

namespace WEBECO.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        List<Category> ICategoryService.GetAll()
        {
            return _categoryDal.GetAll();
        }

        Category ICategoryService.GetById(int id)
        {
            return _categoryDal.Get(p => p.Id == id);
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }
    }
}
