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
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
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
            throw new NotImplementedException();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
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
