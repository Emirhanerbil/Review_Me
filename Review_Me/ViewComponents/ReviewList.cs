using Microsoft.AspNetCore.Mvc;
using Review_Me.Models;

namespace Review_Me.ViewComponents
{
    public class ReviewList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<SellerReview>
            {
                new SellerReview
                {
                    ID = 1,
                    Sellername = "Emirhan"
                },
                new SellerReview
                {
                    ID = 2,
                    Sellername = "Mustafa"
                },

            };
            return View(commentValues);
        }

    }
}
