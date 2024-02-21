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
    public class DestinationManager : IDestinationService
    {
        private readonly IDalManager _dalManager;

        public DestinationManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(Destination entity)
        {
            _dalManager.Destination.Delete(entity);
        }

        public Destination TFindByCondition(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _dalManager.Destination.GetById(id);

        }

        public Destination TGetDestinationWithGuideById(int id)
        {
            return _dalManager.Destination.GetDestinationWithGuideById(id);
        }

        public List<Destination> TGetList()
        {
            return _dalManager.Destination.GetList();
        }

        public List<Destination> TGetListById(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Destination entity)
        {
            _dalManager.Destination.Insert(entity);
        }

        public void TUpdate(Destination entity)
        {
            _dalManager.Destination.Update(entity);
        }
    }
}
