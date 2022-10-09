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
    public class _SubAboutPartial : ViewComponent
    {


        SubAboutManager manager = new SubAboutManager(new EfSubAboutDal());


        public IViewComponentResult Invoke()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }
    }
}
