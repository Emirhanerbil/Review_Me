﻿using EntityLayer.Concrete;

namespace Review_Me.Models
{
    public class ContentSellerUser
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<Seller> Sellers { get; set; }
        public IEnumerable<Content> Contents { get; set; }

    }
}
