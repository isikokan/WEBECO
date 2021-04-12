using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Core.DataAccess;
using WEBECO.Entities.Concrete;

namespace WEBECO.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
