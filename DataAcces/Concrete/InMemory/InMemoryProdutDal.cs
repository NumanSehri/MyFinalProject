﻿using DataAcces.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAcces.Concrete.InMemory
{
    public class InMemoryProdutDal : IProductDal

    {
        //değişken oluşturuldu
        List<Product> _products;
        public InMemoryProdutDal()
        { //Oracle,Sql Server,Postgres,MongoDb
            _products = new List<Product> {
            new Product{ ProductId=1,CategoryId=1,ProductName="Masa",UnitPrice=100,UnitInStock=12},
           new Product{ ProductId=2,CategoryId=1,ProductName="Sandalye",UnitPrice=80,UnitInStock=20},
            new Product{ ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=550,UnitInStock=5},
            new Product{ ProductId=4,CategoryId=2,ProductName="Kılıf",UnitPrice=30,UnitInStock=25},
            new Product{ ProductId=5,CategoryId=2,ProductName="Kamera",UnitPrice=400,UnitInStock=3}};
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            //LINQ - Langıage Integrated Query
            //Lambda
            Product productToDelete;
            
            
            //LINQ ile, singleordefault tek veri arar, PK aranırken kullanılır.  
            productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

            _products.Remove(productToDelete);
        }

        public List<Product> GetAll() //tümünü döndür
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün İd'sine sahip olan listedeki ürünü bul
           Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;

        }
    }
}
