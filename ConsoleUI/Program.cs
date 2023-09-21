﻿// See https://aka.ms/new-console-template for more information


using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;

ProductTest();
//IoC
//CategoryTest();
static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal(),
        new CategoryManager(new EfCategoryDal()));
    var result = productManager.GetProductDetails();

    if (result.Success==true)
    {
        foreach (var product in productManager.GetProductDetails().Data)
        {
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
    else { Console.WriteLine(result.Message); }
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll().Data)
    {
        Console.WriteLine(category.CategoryName);
    }
}
