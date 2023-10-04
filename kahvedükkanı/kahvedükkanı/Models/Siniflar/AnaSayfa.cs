using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace kahvedükkanı.Models.Siniflar
{
    public class AnaSayfa
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImgUrl { get; set; }
        public ICollection<Menu> Menus { get; set; }


    }
}