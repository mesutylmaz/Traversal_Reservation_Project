using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;     //IViewComponentResult için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Default
{
    public class _PopularDestinationsPartial:ViewComponent
    {

        DestinationManager manager = new DestinationManager(new EfDestinationDal());


        public IViewComponentResult Invoke()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }
    }
}
