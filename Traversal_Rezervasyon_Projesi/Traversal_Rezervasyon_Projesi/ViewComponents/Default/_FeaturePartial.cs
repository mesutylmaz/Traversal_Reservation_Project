using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Default
{
    public class _FeaturePartial : ViewComponent
    {

        FeatureManager manager = new FeatureManager(new EfFeatureDal());


        public IViewComponentResult Invoke()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }
    }
}
