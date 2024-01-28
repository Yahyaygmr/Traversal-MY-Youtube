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
    public class SubAboutManager : ISubAboutService
    {
        private readonly IDalManager _dalManager;

        public SubAboutManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public SubAbout TFindByCondition(Expression<Func<SubAbout, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _dalManager.SubAbout.GetList();
        }

        public List<SubAbout> TGetListById(Expression<Func<SubAbout, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(SubAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(SubAbout entity)
        {
            throw new NotImplementedException();
        }
    }
}
