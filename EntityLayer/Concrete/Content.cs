using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        public string Title { get; set; }
        public string ContentText { get; set; }
        public int? JobPhoto { get; set; }
        public DateTime ContentDate { get; set; }
        public bool isFlagged { get; set; }
        public string? FlagContent { get; set; }

        

        public User User { get; set; }
        public int UserID { get; set; }
        public Seller Seller { get; set; }
        public int SellerID { get; set; }
    }
}
