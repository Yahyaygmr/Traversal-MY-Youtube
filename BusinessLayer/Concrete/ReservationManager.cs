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

        public List<Reservation> GetListAllReservationByUserId(int id)
        {
            return _dalManager.Reservation.GetListAllReservationByUserId(id);
        }

        public List<Reservation> GetListReservationByAccepted(int id)
        {
            return _dalManager.Reservation.GetListReservationByAccepted(id);
        }

        public List<Reservation> GetListReservationByPrevious(int id)
        {
            return _dalManager.Reservation.GetListReservationByPrevious(id);
        }

        public List<Reservation> GetListReservationByWaitApproval(int id)
        {
            return _dalManager.Reservation.GetListReservationByWaitApproval(id);
        }

        public void TDelete(Reservation entity)
        {
            throw new NotImplementedException();
        }

        public Reservation TFindByCondition(Expression<Func<Reservation, bool>> expression)
        {
            return _dalManager.Reservation.FindByCondition(expression);
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {

            return _dalManager.Reservation.GetList();
        }

        public List<Reservation> TGetListById(Expression<Func<Reservation, bool>> expression)
        {
            return _dalManager.Reservation.GetListByFilter(expression).ToList();
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
