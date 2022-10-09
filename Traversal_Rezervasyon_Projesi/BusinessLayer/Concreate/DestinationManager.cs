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
    public class DestinationManager : IDestinationService
    {
        #region Dependency Injection
        IDestinationDal _destinationDal;        //IAboutDal'dan veri kullanabilmek için bir değişken(_aboutDal) tanımladık.

        public DestinationManager(IDestinationDal destinationDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _destinationDal = destinationDal;
        }
        #endregion

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(Destination t)
        {
            _destinationDal.Delete(t);
        }

        public Destination TGetByID(int id)
        {
            return _destinationDal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            _destinationDal.Update(t);
        }
    }
}
