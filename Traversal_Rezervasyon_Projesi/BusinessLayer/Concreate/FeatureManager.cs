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
    public class FeatureManager : IFeatureService
    {

        #region Dependency Injection
        IFeatureDal _featureDal;        //IFeatureDal'dan veri kullanabilmek için bir değişken(_featureDal) tanımladık.

        public FeatureManager(IFeatureDal featureDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _featureDal = featureDal;
        }
        #endregion


        public void TAdd(Feature t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature t)
        {
            throw new NotImplementedException();
        }

        public Feature TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature t)
        {
            throw new NotImplementedException();
        }
    }
}
