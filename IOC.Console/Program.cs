using System;

namespace IOC.Console
{
    class Program
    {
        static void Main()
        {
            BL bL = new BL(new DAL());
            foreach (var item in bL.GetProducts())
            {
                System.Console.WriteLine(item.Id +"__"+ item.ProductName +"__"+item.Price +"__" );

            }

            System.Console.ReadLine();
            
        }
    }
}
  