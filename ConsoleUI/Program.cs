﻿// See https://aka.ms/new-console-template for more information


using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}

