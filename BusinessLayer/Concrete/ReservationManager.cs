using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        private readonly IDalManager _dalManager;

        public ReservationManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TFindByCondition(Expression<Func<Reservation, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetListById(Expression<Func<Reservation, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Reservation entity)
        {
            _dalManager.Reservation.Insert(entity);
        }

        public void TUpdate(Reservation entity)
        {
            throw new NotImplementedException();
        }
    }
}
