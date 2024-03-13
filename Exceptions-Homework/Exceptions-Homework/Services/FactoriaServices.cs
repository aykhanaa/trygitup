using Exceptions_Homework.Helpers.Excepsion;
using Exceptions_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Services
{
    public class FactoriaServices : IFactorialservices
    {
        public string FindFactorial(int? m)
        {
            int result=1;
            try
            {
                if (m == 0)
                {
                    result = 1;
                }
                else if (m<0)
                {
                    throw new CustomNegativeNumber("Faktorial menfi eded ola bilmez");
                }
                for (int i = 1; i <= m; i++)
                {
                    result *= i;
                }
                return result.ToString();
            }
            catch (Exception msj)
            {

                return msj.Message;
            }
        }
        
    }
}
