using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class IContentService
    {
        void ContentAdd(Content content);
        void ContentRemove(Content content);
        Content GetContentByID(int id);
        List<Content> GetContents();
        void ContentUpdate(Content content);
    }
}
