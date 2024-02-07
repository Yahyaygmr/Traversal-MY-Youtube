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
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly Context _context;
        public EfReservationDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Reservation> GetListReservationByAccepted(int id)
        {
            return _context.Reservations
              .Include(x => x.Destination)
              .Where(x => x.Status == "Onaylandı" && x.AppUserId == id)
              .ToList();
        }

        public List<Reservation> GetListReservationByPrevious(int id)
        {
            return _context.Reservations
                .Include(x => x.Destination)
                .Where(x => x.Status == "Geçmiş Rezervasyon" && x.AppUserId == id)
                .ToList();
        }

        public List<Reservation> GetListAllReservationByUserId(int id)
        {
            return _context.Reservations
                .Include(x => x.Destination)
                .Where(x => x.AppUserId == id)
                .ToList();
        }

        public List<Reservation> GetListReservationByWaitApproval(int id)
        {
            return _context.Reservations
                .Include(x => x.Destination)
                .Where(x => x.Status == "Onay Bekliyor" && x.AppUserId == id)
                .ToList();
        }
    }
}
