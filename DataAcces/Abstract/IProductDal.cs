using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Abstract
{

    //Product ile yapacağım işlemler burda imzalanır
    public interface IProductDal
    {
        //Product verileri listele
        List<Product> GetAll();
        //Veri Ekle
        void Add(Product product);
        //Veri Güncelle
        void Update(Product product);
        //Veri Sil
        void Delete(Product product);
        //Productları category id'sine göre listele
        List<Product> GetAllByCategory(int categoryId);

    }
}
