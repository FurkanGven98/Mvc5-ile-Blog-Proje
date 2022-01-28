using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private Repository<Category> repoCategory = new Repository<Category>();

        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return repoCategory.List();

        }
        public int CategoryAddBL(Category p)
        {
            return repoCategory.Insert(p);
        }
        public Category FindCategory(int id)
        {
            return repoCategory.Find(x => x.CategoryID == id);
        }

        public int EditCategory(Category p)
        {
            Category category = repoCategory.Find(x => x.CategoryID == p.CategoryID);
            if (p.CategoryName == "" | p.CategoryName.Length <= 2 | p.CategoryName.Length >= 30)
            {
                return -1;
            }
            category.CategoryName = p.CategoryName;
            category.CategoryDescription = p.CategoryDescription;
            return repoCategory.Update(category);
        }
        public int CategoryStatusFalseBL(int id)
        {
            Category category = repoCategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = false;
            return repoCategory.Update(category);
        }
        public int CategoryStatusTrueBL(int id)
        {
            Category category = repoCategory.Find(x => x.CategoryID == id);
            category.CategoryStatus = true;
            return repoCategory.Update(category);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
