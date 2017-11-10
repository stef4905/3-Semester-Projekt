using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
   public class Applier
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string BannerURL { get; set; }
        public string ImageURL { get; set; }
        public int MaxRadius { get; set; }
        public string HomePage { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public bool Status { get; set; }

        public Applier(int id, string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }
    }
}
