using Exceptions_Homework.Services;
using Exceptions_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Controlles
{
    public class MathFactorialController
    {
        private readonly IFactorialservices _factorialservices;

        public MathFactorialController()
        {
            _factorialservices = new FactoriaServices();
        }

        public void FindFactorial()
        {
            Console.WriteLine("Add number");
            int m= int.Parse(Console.ReadLine());
            Console.WriteLine(_factorialservices.FindFactorial(m));
        }

    }
}
