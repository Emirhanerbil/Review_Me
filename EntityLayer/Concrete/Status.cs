using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public int StatusFlag { get; set; }
        public string? FlagContent { get; set; }
        public virtual Content Content { get; set; }

    }
}
