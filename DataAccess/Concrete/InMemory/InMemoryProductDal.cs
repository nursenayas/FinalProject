﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {

                new Product{ProductID=1,CategoryID=1,ProductName="Bardak",UnitPrice=15, UnitStok=15},
                new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=500, UnitStok=3},
                new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=1500, UnitStok=2},
                new Product{ProductID=4,CategoryID=2,ProductName="Klavye",UnitPrice=150, UnitStok=65},
                new Product{ProductID=5,CategoryID=2,ProductName="Fare",UnitPrice=85, UnitStok=1},

            };
        }


        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Intagrated Query
            /*   Product productToDelete = null;
               foreach (var p in _products)
               {
                   if (product.ProductId == p.ProductId)
                   {
                       productToDelete = p;

                   }
               }*/

            //Üstteki forech alanının yerine alt satırda eklenen kod yazılabilir. Daha pratik
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }



        public void Update(Product product)
        {
            //Gönderdiğim ürün idsine sahip olan listedeki id yi bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductID = product.ProductID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitStok = product.UnitStok;

            _products.Add(productToUpdate);

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}