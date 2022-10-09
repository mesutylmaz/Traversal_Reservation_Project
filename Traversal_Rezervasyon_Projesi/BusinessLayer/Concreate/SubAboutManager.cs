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
    public class SubAboutManager : ISubAboutService
    {


        #region Dependency Injection
        ISubAboutDal _subAboutDal;        //ISubAboutDal'dan veri kullanabilmek için bir değişken(_subAboutDal) tanımladık.

        public SubAboutManager(ISubAboutDal subAboutDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _subAboutDal = subAboutDal;
        }
        #endregion








        public void TAdd(SubAbout t)
        {
            _subAboutDal.Insert(t);
        }

        public void TDelete(SubAbout t)
        {
            _subAboutDal.Delete(t);
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout t)
        {
            _subAboutDal.Update(t);
        }
    }
}
