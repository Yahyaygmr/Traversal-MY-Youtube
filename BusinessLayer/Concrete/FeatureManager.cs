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
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TDelete(Feature entity)
        {
            throw new NotImplementedException();
        }

        public Feature TFindByCondition(Expression<Func<Feature, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public List<Feature> TGetListById(Expression<Func<Feature, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void TInsert(Feature entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Feature entity)
        {
            throw new NotImplementedException();
        }
    }
}
