using Exceptions_Homework.Modells;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Services.Interfaces
{
    public interface IUserService
    {
        User[] GetAll();
        public string FindUserByEmailAndPassword(User[] users, string email, string password);
       
          
    }
}
