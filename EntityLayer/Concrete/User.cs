using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastname { get; set; }
        public DateTime BirthDate { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public string? UserPhoto { get; set; }
        public ICollection<Content> Content { get; set; }
    }
}
