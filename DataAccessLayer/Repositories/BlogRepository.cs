using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository : IBlogDal
    {
        public void AddBlog(Blog blog)
        {
            using var ctx = new Context();
            ctx.Add(blog);
            ctx.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            using var ctx = new Context();
            ctx.Remove(blog);
            ctx.SaveChanges();
        }

        public Blog GetById(int id)
        {
            using var ctx = new Context();
            return ctx.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            using var ctx = new Context();
            return ctx.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            using var ctx = new Context();
            ctx.Update(blog);
            ctx.SaveChanges();
        }
    }
}
