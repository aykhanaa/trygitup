using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Helpers.Excepsion
{
    internal class CustomNegativeNumber:Exception
    {
        public CustomNegativeNumber(string msj):base(msj)
        {
            
        }
    }


}
