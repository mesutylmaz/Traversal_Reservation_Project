using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Default
{
    public class _TestimonialPartial : ViewComponent
    {


        TestimonialManager manager = new TestimonialManager(new EfTestimonialDal());


        public IViewComponentResult Invoke()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }
    }
}
