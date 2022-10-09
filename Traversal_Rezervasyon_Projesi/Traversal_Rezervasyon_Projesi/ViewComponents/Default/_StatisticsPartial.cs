using DataAccessLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent  //ViewComponent, Asp.net Core ile karşımıza çıktı.
    {                                            //MVC'de bu yoktu. MVC'de Partiallara URL üzerinden direkt ulaşabilirken ViewComponent'lere erişemiyorduk.
        public IViewComponentResult Invoke()
        {
            using var context = new Context();
            ViewBag.Rota = context.Destinations.Count();
            ViewBag.TurRehberi = context.Guides.Count();
            ViewBag.MutluMusteri = "285";
            ViewBag.Odul = "25";
            return View();
        }
    }
}
