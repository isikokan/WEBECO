using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Core.DataAccess.EntityFramework;
using WEBECO.DataAccess.Abstract;
using WEBECO.Entities.Concrete;

namespace WEBECO.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, WebecoContext>, ICategoryDal
    {
    }
}
