using BusinessLayer.Concreate;
using DataAccessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.Controllers
{
    public class DestinationController : Controller
    {

        DestinationManager manager = new DestinationManager(new EfDestinationDal());
        Context db = new Context();

        public IActionResult Index()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }


        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
<<<<<<< HEAD
            ViewBag.ID = id;
=======
            Random rnd = new Random();
            int sayi = rnd.Next(0, 5);
>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c

            var values = manager.TGetByID(id);

            var sehir = db.MeaningfulArticles.Where(x => x.City == values.City).Select(x => x.City).ToList();
            var yazi = db.MeaningfulArticles.Where(x => x.City == values.City).Select(x => x.Article).ToList();
<<<<<<< HEAD
            var foto = db.MeaningfulArticles.Where(x => x.City == values.City).Select(x => x.Photo).ToList();
            var yazar = db.MeaningfulArticles.Where(x => x.City == values.City).Select(x => x.WriterName + " " + x.WriterSurname).ToList();
            var adet = yazi.Count();
            


            Random rnd = new Random();
            int sayi = rnd.Next(0, adet);
            var sayi2 = sayi + 1;

            if (yazi != null && foto != null && yazar !=null && sehir != null)
=======
            var yazar = db.MeaningfulArticles.Where(x => x.City == values.City).Select(x => x.WriterName + " " + x.WriterSurname).ToList();

            if (yazi != null)
>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c
            {
                ViewBag.SehirYazilari = yazi[sayi];
                ViewBag.Yazar = yazar[sayi];
                ViewBag.IlkHarf = sehir[sayi][0];   //Şehrin İlk Harfi
<<<<<<< HEAD
                ViewBag.Foto = foto[sayi];
                ViewBag.Foto2 = foto[sayi2];
=======

>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c
            }

            return View(values);
        }


        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
