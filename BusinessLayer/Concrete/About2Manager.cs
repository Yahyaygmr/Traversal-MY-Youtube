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
    public class About2Manager : IAbout2Service
    {
        public void TDelete(About2 entity)
        {
            throw new NotImplementedException();
        }

        public About2 TFindByCondition(Expression<Func<About2, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public About2 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<About2> TGetListById(Expression<Func<About2, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(About2 entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About2 entity)
        {
            throw new NotImplementedException();
        }
    }
}
