using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {
        IContentDal contentDal;

        public ContentManager(IContentDal contentDal)
        {
            this.contentDal=contentDal;
        }

        public void ContentAdd(Content content)
        {
            contentDal.Insert(content);
            
        }

        public void ContentRemove(Content content)
        {
            contentDal.Delete(content);
        }

        public void ContentUpdate(Content content)
        {
            contentDal.Update(content);
        }

        public Content GetContentByID(int id)
        {
            return contentDal.GetById(id);
        }

        public List<Content> GetContents()
        {
            return contentDal.GetAll();
        }
    }
}
