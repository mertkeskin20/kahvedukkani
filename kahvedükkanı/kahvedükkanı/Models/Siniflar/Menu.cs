using System.ComponentModel.DataAnnotations;

namespace kahvedükkanı.Models.Siniflar
{
    public class Menu
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductImgUrl { get; set; }
        public int CategoryID { get; set; }
        public virtual AnaSayfa AnaSayfa { get; set; }

        //public AnaSayfa CategoryName { get; set; }

        //public int CategoryID { get; set; }
        


    }
}