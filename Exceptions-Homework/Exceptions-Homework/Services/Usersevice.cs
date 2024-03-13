using Exceptions_Homework.Helpers.Excepsions;
using Exceptions_Homework.Modells;
using Exceptions_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_Homework.Services
{
    internal class Usersevice : IUserService
    {

        public string FindUserByEmailAndPassword(User[] users, string email, string password)
        {
            try
            {
                var result = users.FirstOrDefault(m => m.Email == email || m.Password == password);
                if (result!= null)
                {
                    return "Success";
                }
                else
                {
                    throw new CustomNullEmptyExcepsion("Data notfound");
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public User[] GetAll()
        {
            User user1 = new User()
            {
                Id = 1,
                Name = "Aykhan",
                Surname = "Aghayev",
                Age = 23,
                Email = "aykhan@gmail.com",
                Password = "123",
            };
            User user2 = new User()
            {
                Id = 2,
                Name = "Asgarxan",
                Surname = "Bayramov",
                Age = 26,
                Email = "asgarxan@gmail.com",
                Password = "45679",
            };

            User user3 = new User()
            {
                Id = 3,
                Name = "Bahruz",
                Surname = "Aliyev",
                Age = 37,
                Email = "bahruz@gmail.com",
                Password = "78956",
            };

            User user4 = new User()
            {
                Id = 4,
                Name = "Hacixan",
                Surname = "Hacixanov",
                Age = 21,
                Email = "hacixan@gmail.com",
                Password = "45689",
            };
            return new User[] { user1, user2, user3, user4,};




        }
    }
}
