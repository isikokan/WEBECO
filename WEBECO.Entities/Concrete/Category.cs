using System;
using System.Collections.Generic;
using System.Text;
using WEBECO.Core.Entities.Abstract;

namespace WEBECO.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
