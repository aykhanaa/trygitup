using Exceptions_Homework.Modells;
using Exceptions_Homework.Services;
using Exceptions_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Controlles
{
    public class UserController
    {
        private readonly IUserService _userService;

        public UserController()
        {
            _userService = new Usersevice();


        }
        public void GetAll()
        {
            var users = _userService.GetAll();
            foreach (var user in users)
            {
                string result = $"{user.Name} {user.Surname} {user.Age} {user.Email} {user.Password}";
                Console.WriteLine(result);
            }
        }
        public void FindUserByEmailAndPassword()
        {
            Console.WriteLine("Enter your login:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

          var result = _userService.FindUserByEmailAndPassword(_userService.GetAll(), email, password);

            Console.WriteLine(result);

        }
    }
}
