using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        void ContentAdd(Content content);
        void ContentRemove(Content content);
        Content GetContentByID(int id);
        List<Content> GetContents(int id);
        void ContentUpdate(Content content);
        List<Content> GetContentByName(string name);

        List<Content> GetContentWithSeller();
    }
}
