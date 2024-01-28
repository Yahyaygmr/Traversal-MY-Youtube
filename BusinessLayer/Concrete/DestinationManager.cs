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
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal, IDalManager dalManager)
        {
            _destinationDal = destinationDal;
            _dalManager = dalManager;
        }

        public void TDelete(Destination entity)
        {
            throw new NotImplementedException();
        }

        public Destination TFindByCondition(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Destination TGetById(int id)
        {
            return _destinationDal.GetById(id);

        }

        public List<Destination> TGetList()
        {
            return _dalManager.Destination.GetList();
            //return _destinationDal.GetList();
        }

        public List<Destination> TGetListById(Expression<Func<Destination, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Destination entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Destination entity)
        {
            throw new NotImplementedException();
        }
    }
}
