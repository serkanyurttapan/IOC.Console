using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
    public class DAL :IDal
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id =1,
                    Price=5,
                    ProductName="Test"
                },
                   new Product()
                {
                    Id =2,
                    Price=5,
                    ProductName="Test2"
                },
                      new Product()
                {
                    Id =3,
                    Price=5,
                    ProductName="Test3"
                }
            };
        }
    }
}
