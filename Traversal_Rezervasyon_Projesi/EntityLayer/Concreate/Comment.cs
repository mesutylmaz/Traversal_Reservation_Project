using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Comment    //Blog altındaki yorum kısmı
    {
        public int CommentID { get; set; }
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }
        public bool CommentState { get; set; }




        public int Destinationid { get; set; }
        public Destination Destination { get; set; }
    }
}
