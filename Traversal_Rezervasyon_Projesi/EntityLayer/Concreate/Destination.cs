using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Destination    //Blog Bilgileri
    {
        [Key]
        public int DestinationID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public bool Status { get; set; }
        public string Details1 { get; set; }        //Details Sayfasında kullanılacak metin1
        public string Details2 { get; set; }        //Details Sayfasında kullanılacak metin2
<<<<<<< HEAD


        public List<Comment>Comments { get; set; }
=======
        public string Image2 { get; set; }      //Details Sayfasında kullanılacak yardımcı resim
>>>>>>> 17a9233d6a36fab8006de0f0d9d2d161d7ef673c
    }
}
