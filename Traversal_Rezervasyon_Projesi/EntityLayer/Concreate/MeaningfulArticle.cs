using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class MeaningfulArticle      //Şehirler için anlamlı yazılar
    {
        public int ID { get; set; }
        public string Article { get; set; }     //Yazı
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string City { get; set; }
        public bool State { get; set; }
<<<<<<< HEAD
        public string Photo { get; set; }
=======
>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c
    }
}
