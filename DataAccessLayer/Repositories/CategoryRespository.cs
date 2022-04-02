using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRespository : ICategoryDal
    {
        Context ctx = new Context();
        public void AddCategory(Category category)
        {
            ctx.Add(category);
            ctx.SaveChanges();
        }

        public void Delete(Category item)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            ctx.Remove(category);
            ctx.SaveChanges();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return ctx.Categories.Find(id);
        }

        public List<Category> GetListAll(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category item)
        {
            throw new NotImplementedException();
        }

        public List<Category> ListAllCategory()
        {
            return ctx.Categories.ToList();
        }

        public void Update(Category item)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            ctx.Update(category);
            ctx.SaveChanges();
        }
    }
}
