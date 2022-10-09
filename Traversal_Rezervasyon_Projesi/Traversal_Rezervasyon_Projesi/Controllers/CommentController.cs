using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal_Rezervasyon_Projesi.Controllers
{
    public class CommentController : Controller
    {
        CommentManager manager = new CommentManager(new EfCommentDal());


        [HttpGet]
        public PartialViewResult AddComment()      
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment comment)      
        {
            comment.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            comment.CommentState = true;
            comment.Destinationid=3;    //Burayı sonra dinakim yapıcaz.
            manager.TAdd(comment);
            return RedirectToAction("Index","Destination");
        }
    }
}
