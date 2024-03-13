using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Helpers.Excepsions
{
    public class CustomNullEmptyExcepsion:Exception
    {
        public CustomNullEmptyExcepsion(string msj):base(msj)
        {

        }
    }
}
