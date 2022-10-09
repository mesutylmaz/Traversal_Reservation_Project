using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.ViewComponents.Comment
{
    public class _CommentListFilterPartial : ViewComponent
    {
        CommentManager manager = new CommentManager(new EfCommentDal());


        public IViewComponentResult Invoke(int id)      //Şartlı listeleme yapacak(T,BOOL => entity durumuna göre true/false)
        {
            var degerler = manager.TGetDestinationByID(id);
            return View(degerler);
        }
    }
}
