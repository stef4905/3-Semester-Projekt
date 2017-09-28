using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataAccessLayer;
using BusinessLogicLayer;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DbUser dbUser = new DbUser();

            //User user = new User(1,"Gundhild den søde");
            //dbUser.create(user);

            //User newUser = dbUser.Get(1);
            //Console.WriteLine(newUser.FName);
          

            //dbUser.Delete(1);

            //User newTrab = new User(2, "Trab");
            //dbUser.Update(newTrab);

            List<User> UserList = dbUser.GetAll();
            
            Console.WriteLine(UserList.Count());

            foreach (var user in UserList)
            {

                Console.WriteLine(user.FName);

            }
            Console.ReadLine();

        }
    }
}
