using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
    class BL
    {
        private IDal Dal { get; set; }
        public BL(IDal dal)
        {
            Dal = dal;
        }
        public List<Product> GetProducts()
        {
            return Dal.GetProducts();
        }
    }
}
