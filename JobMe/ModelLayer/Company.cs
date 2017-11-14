using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public int Phone { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string ImageURL { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string BannerURL { get; set; }
        [DataMember]
        public int MaxRadius { get; set; }
        [DataMember]
        public string Homepage { get; set; }
        [DataMember]
        public string CompanyName { get; set; }
        [DataMember]
        public int CVR { get; set; }
        [DataMember]
        public BusinessType businessType { get; set; }

        /// <summary>
        /// Constructor for Company Class.
        /// Sets the required parameters for the Company Class.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public Company(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
