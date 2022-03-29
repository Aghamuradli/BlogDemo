using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        CategoryRespository categoryRespository= new CategoryRespository();
        public void CategoryAdd(Category category)
        {
            categoryRespository.AddCategory(category);
        }

        public void CategoryDelte(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
