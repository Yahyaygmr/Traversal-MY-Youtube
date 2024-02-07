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
    public class CommentManager : ICommentService
    {
        private readonly IDalManager _dalManager;

        public CommentManager(IDalManager dalManager)
        {
            _dalManager = dalManager;
        }

        public List<Comment> GetAllCommentsWithDestinations()
        {
            return _dalManager.Comment.GetAllCommentsWithDestinations();
        }

        public void TDelete(Comment entity)
        {
            _dalManager.Comment.Delete(entity);
        }

        public Comment TFindByCondition(Expression<Func<Comment, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            return _dalManager.Comment.GetById(id);
        }

        public List<Comment> TGetList()
        {
           return _dalManager.Comment.GetList();
        }

        public List<Comment> TGetListById(Expression<Func<Comment, bool>> expression)
        {
            return _dalManager.Comment.GetListByFilter(expression);
        }

        public void TInsert(Comment entity)
        {
            _dalManager.Comment.Insert(entity);
        }

        public void TUpdate(Comment entity)
        {
            _dalManager.Comment.Update(entity);
        }
    }
}
