using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Company
    {
        public int id { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string ImageURL { get; set; }
        public string Description { get; set; }
        public string BannerURL { get; set; }
        public int MaxRadius { get; set; }
        public string Homepage { get; set; }
        public string CompanyName { get; set; }
        public int CVR { get; set; }
        public BusinessType businessType { get; set; }

        public Company(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
