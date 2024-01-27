using BusinessLayer.Abstract;
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
        public void TDelete(Guide entity)
        {
            throw new NotImplementedException();
        }

        public Guide TFindByCondition(Expression<Func<Guide, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guide> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Guide entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Guide entity)
        {
            throw new NotImplementedException();
        }
    }

}
