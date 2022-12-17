using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

        public List<Content> GetContentByName(string name)
        {
            var ctx = new Context();
            //var list = ctx.Contents.FromSql($"select * from Contents where  Contents.ContentText like '%' + '{name}' + '%' or Contents.Title like '%' + '{name}' + '%' ").ToList();
            //return list;
            var degerler = from d in ctx.Contents select d;
            if (!string.IsNullOrEmpty(name))
            {
                degerler = degerler.Where(x => x.ContentText.Contains(name) || x.Title.Contains(name));
            }
            return degerler.ToList();
            
        }

        public List<Content> GetContents()
        {
            return contentDal.GetAll();
        }
    }
}
