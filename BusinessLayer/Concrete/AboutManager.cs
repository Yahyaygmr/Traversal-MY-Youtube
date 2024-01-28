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
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _abotDal;

        public AboutManager(IAboutDal abotDal)
        {
            _abotDal = abotDal;
        }

        public void TDelete(About entity)
        {
            _abotDal.Delete(entity);
        }

        public About TFindByCondition(Expression<Func<About, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _abotDal.GetList();
        }

        public List<About> TGetListById(Expression<Func<About, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(About entity)
        {
            _abotDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _abotDal.Update(entity);
        }
    }
}
