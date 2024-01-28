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
    public class Feature1Manager : IFeature1Service
    {
        public void TDelete(Feature1 entity)
        {
            throw new NotImplementedException();
        }

        public Feature1 TFindByCondition(Expression<Func<Feature1, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Feature1 TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature1> TGetList()
        {
            throw new NotImplementedException();
        }

        public List<Feature1> TGetListById(Expression<Func<Feature1, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Feature1 entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature1 entity)
        {
            throw new NotImplementedException();
        }
    }
}
