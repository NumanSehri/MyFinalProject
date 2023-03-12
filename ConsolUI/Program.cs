using Business.Concrete;
using DataAcces.Concrete.EntityFramework;
using System;

namespace ConsolUI
{
    //SOLID
    //O : Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {   //IoC öğrenildiğinde newlenmeyecek 12.03.2023
            //ProductTest();
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine("Kategori İd : {0} ------- Kategori Adı :  {1}",category.CategoryID,category.CategoryName);

            }

            foreach (var item in categoryManager.GetById(3))
            {
                Console.WriteLine("Kategori Id İle Eşleşen Kategori Adı : " + item.CategoryName);
            }



        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var byUnitPrie in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine("Değeri En az 50 En Fazla 100 olan Ürünler : {0}", byUnitPrie.ProductName);
            }

            foreach (var ıd in productManager.GetAllCategoryId(2))

            {
                Console.WriteLine("Id : {0}------ Ürün Adı :  {1}--- İstenilen Katagori Id göre Sıralar", ıd.CategoryId, ıd.ProductName);
            }

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine("Tüm ürünlerin aları : {0}", product.ProductName);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
