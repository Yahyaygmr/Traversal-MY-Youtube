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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly Context _context;
        public EfCommentDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetAllCommentsWithDestinations()
        {
            return _context.Comments
                .Include(x => x.DEstination)
                .ToList();
        }

        public List<Comment> GetAllCommentsWithDestinationsAndUser()
        {
            return _context.Comments
                .Include(x => x.DEstination)
                .Include(x=> x.AppUser)
                .ToList();
        }

        public List<Comment> GetAllCommentsWithDestinationsAndUserByDestinationId(int id)
        {
            return _context.Comments
                .Include(x => x.DEstination)
                .Include(x => x.AppUser)
                .Where(x => x.DestinationId == id)
                .ToList();
        }
    }
}
