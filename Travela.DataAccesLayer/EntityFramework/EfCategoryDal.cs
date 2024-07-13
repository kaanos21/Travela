using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travela.DataAccesLayer.Abstract;
using Travela.DataAccesLayer.Context;
using Travela.DataAccesLayer.Repositories;
using Travela.EntityLayer.Concrete;

namespace Travela.DataAccesLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(TravelaContext context) : base(context)
        {
            
        }

        public int GetCategoryCount()
        {
            var context=new TravelaContext();
            var value=context.Categories.Count();
            return value;
        }
    }
}
