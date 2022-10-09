using Microsoft.AspNetCore.Mvc;     //ViewComponent için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent  //ViewComponent, Asp.net Core ile karşımıza çıktı.
    {                                            //MVC'de bu yoktu. MVC'de Partiallara URL üzerinden direkt ulaşabilirken ViewComponent'lere erişemiyorduk.
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }                                             

}
