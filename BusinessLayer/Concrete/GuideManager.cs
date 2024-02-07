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
    public class GuideManager : IGuideService
    {
        private readonly IDalManager _dalManager;

        public GuideManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public void TDelete(Guide entity)
        {
            _dalManager.Guide.Delete(entity);
        }

        public Guide TFindByCondition(Expression<Func<Guide, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            return _dalManager.Guide.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _dalManager.Guide.GetList();
        }

        public List<Guide> TGetListById(Expression<Func<Guide, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Guide entity)
        {
            _dalManager.Guide.Insert(entity);
        }

        public void TUpdate(Guide entity)
        {
            _dalManager.Guide.Update(entity);
        }
    }

}
