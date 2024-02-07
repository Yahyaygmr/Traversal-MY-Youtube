using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IDalManager _dalManager;

        public AppUserManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(AppUser entity)
        {
            _dalManager.AppUser.Delete(entity);
        }

        public AppUser TFindByCondition(Expression<Func<AppUser, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            return _dalManager.AppUser.GetById(id);
        }

        public List<AppUser> TGetList()
        {
           return _dalManager.AppUser.GetList();
        }

        public List<AppUser> TGetListById(Expression<Func<AppUser, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(AppUser entity)
        {
            _dalManager.AppUser.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
            _dalManager.AppUser.Update(entity);
        }
    }
}
