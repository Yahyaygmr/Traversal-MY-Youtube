using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfDestinationDal : GenericRepository<Destination>, IDestinationDal
    {
        private readonly Context _context;
        public EfDestinationDal(Context context) : base(context)
        {
            _context = context;
        }

        public Destination GetDestinationWithGuideById(int id)
        {
            return _context.Destinations
                .Where(x=>x.DestinationId == id)
                .Include(x =>x.Guide).FirstOrDefault();
        }

        public List<Destination> GetLastFourDestinations()
        {
            return _context.Destinations
                .OrderByDescending(x => x.DestinationId)
                .Take(4)
                .Include(x => x.Guide)
                .ToList();
        }
    }
}
