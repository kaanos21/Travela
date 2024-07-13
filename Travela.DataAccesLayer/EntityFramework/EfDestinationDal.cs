using Microsoft.EntityFrameworkCore;
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
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {

        private readonly TravelaContext _context;

        public EfDestinationDal(TravelaContext context) : base(context)
        {
            _context = context;
        }

        public List<Destination> GetDestinationByCategoryList(int id)
        {
            return _context.Destinations.Where(x=>x.CategoryId == id).Include(x=>x.Category).ToList();
        }

        public List<Destination> GetDestinationByCategoryListAll()
        {
            return _context.Destinations.Include(x => x.Category).ToList();
        }
    }
}
