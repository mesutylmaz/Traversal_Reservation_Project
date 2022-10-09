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
    public class AboutManager : IAboutService
    {

        #region Dependency Injection
        IAboutDal _aboutDal;        //IAboutDal'dan veri kullanabilmek için bir değişken(_aboutDal) tanımladık.

        public AboutManager(IAboutDal aboutDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _aboutDal = aboutDal;
        } 
        #endregion

        public void TAdd(About t)
        {
            _aboutDal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutDal.Update(t);
        }
    }
}
