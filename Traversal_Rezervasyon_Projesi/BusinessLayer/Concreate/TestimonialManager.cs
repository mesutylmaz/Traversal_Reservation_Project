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
    public class TestimonialManager : ITestimonialService
    {


        #region Dependency Injection
        ITestimonialDal _testimonialDal;        //ITestimonialDal'dan veri kullanabilmek için bir değişken(_testimonialDal) tanımladık.

        public TestimonialManager(ITestimonialDal testimonialDal)       //Dependency Injection Yöntemidir. Ctor => Entity'e ait Repoların kullanılabilmesi için gerekli.
        {
            _testimonialDal = testimonialDal;
        }
        #endregion



        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();
        }

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
