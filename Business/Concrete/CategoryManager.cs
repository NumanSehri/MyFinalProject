using Business.Abstract;
using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            //İş Kodları
            return _categoryDal.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c => c.CategoryID == categoryId);
            //İş Kodları

            //veritabanından gelen category ıd ile dışardan verilen
            //categoryıd eşitse o category ıd bağlı verileri getir.
        }

        // select * from categories where CategoryId=3



    }
}
