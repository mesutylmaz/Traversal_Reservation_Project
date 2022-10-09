using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class CommentManager : ICommentService
    {

        #region Dependency Injection
        ICommentDal _commentDal;        //ICommentDal'dan veri kullanabilmek için bir değişken(_commentDal) tanımladık.

        public CommentManager(ICommentDal commentDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _commentDal = commentDal;
        }
        #endregion


        public void TAdd(Comment t)
        {
            _commentDal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentDal.GetByID(id);
        }

        public List<Comment> TGetList()
        {
            return _commentDal.GetList();
        }

        public List<Comment> TGetDestinationByID(int id)
        {
            return _commentDal.GetListByFilter(x=>x.Destinationid==id);
        }

        public void TUpdate(Comment t)
        {
            _commentDal.Update(t);
        }
    }
}
