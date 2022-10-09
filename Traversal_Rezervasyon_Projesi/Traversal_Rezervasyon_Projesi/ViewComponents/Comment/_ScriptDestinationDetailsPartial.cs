using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Comment
{
    public class _ScriptDestinationDetailsPartial : ViewComponent
    {
        CommentManager manager = new CommentManager(new EfCommentDal());


        public IViewComponentResult Invoke()
        {
            var degerler = manager.TGetList();
            return View(degerler);
        }
    }
}
