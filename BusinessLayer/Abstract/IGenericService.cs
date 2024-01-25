using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TDelete(T entity);
        void TUpdate(T entity);
        T TGetById(int id);
        T TFindByCondition(Expression<Func<T, bool>> expression);
        List<T> TGetList();
    }
}
