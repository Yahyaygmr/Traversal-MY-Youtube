using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListReservationByWaitApproval(int id);
        List<Reservation> GetListReservationByAccepted(int id);
        List<Reservation> GetListReservationByPrevious(int id);
        List<Reservation> GetListAllReservationByUserId(int id);
    }
}
