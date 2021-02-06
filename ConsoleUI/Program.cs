using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{//SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {//Data Transformation Object
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CatergoryManager catergoryManager = new CatergoryManager(new EfCategoryDal());
            foreach (var category in catergoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+" / "+product.CategoryName);
            }
        }
    }
}
