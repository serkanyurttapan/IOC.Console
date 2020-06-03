using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.Console
{
   class  DALFactory
    {
        public static IDal GetDal()
        {
            return new DAL();
        }
    }
}
