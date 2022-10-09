using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
<<<<<<< HEAD
        List<T> GetListByFilter(Expression<Func<T,bool>>filter);    //Şartlı listeleme yapacak(T,BOOL => entity durumuna göre true/false)
=======
>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c
    }
}
