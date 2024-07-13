using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccesLayer.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        public int GetCategoryCount();
    }
}
