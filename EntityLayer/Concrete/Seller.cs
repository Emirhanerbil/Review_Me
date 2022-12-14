using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Seller
    {
        public int SellerID { get; set; }
        public string SellerName { get; set; }
        public string SellerLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? SellerPhoto { get; set; }
        public string SellerMail { get; set; }
        public string SellerPasword { get; set; }
        public ICollection<Content> Content { get; set; }
        public Job Job { get; set; }
        public int JobID { get; set; }

    }
}
