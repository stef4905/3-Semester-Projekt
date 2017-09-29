using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobProjectUserClient.JobProjectClientServiceReference1;

namespace JobProjectUserClient
{
    class Program
    {
        private static User[] userList;

        static void Main(string[] args)
        {
            JobProjectUserServiceClient client = new JobProjectUserServiceClient();
            var newUser = new User();
            newUser.FName = "Lang navn";
            client.Create(newUser);
            Console.WriteLine("Client: " + newUser.FName + " with ID: " + newUser.Id + " has been added to DB");
            Console.ReadLine();


            //Get a user with ID
            User getUser = client.Get(3);
            Console.WriteLine("Got user: " + getUser.FName);
            Console.ReadLine();

            //Delete user with id
            int id = 4;
            client.Delete(id);
            Console.WriteLine("User with id: " + id + " has been deleted");
            Console.ReadLine();

            //Update a user
            User updatedUser = new User();
            updatedUser.Id = 5;
            updatedUser.FName = "Updated user";
            client.Update(updatedUser);
            Console.WriteLine("User has ben updated to: " + updatedUser.FName);
            Console.ReadLine();


            //Get All
            userList = client.GetAll();
            foreach (var user in userList) {
                Console.WriteLine("User: " + user.FName);
            }

            Console.ReadLine();
        }
    }
}
