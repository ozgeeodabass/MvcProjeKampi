using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();

        public List<Category> GetAll()
        {
            return repo.List();
        }

        public void Add(Category category)
        {
            if(category.CategoryName=="" || category.CategoryName.Length<=3 || category.CategoryName.Length>= 51 || category.CategoryDescription=="")
            {
                //hata mesajı
            }
            else
            {
                repo.Add(category);
            }


        }
    }
}
