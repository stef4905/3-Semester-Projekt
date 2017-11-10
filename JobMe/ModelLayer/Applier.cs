using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class Applier
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string BannerURL { get; set; }
        [DataMember]
        public string ImageURL { get; set; }
        [DataMember]
        public int MaxRadius { get; set; }
        [DataMember]
        public string HomePage { get; set; }
        [DataMember]
        public string FName { get; set; }
        [DataMember]
        public string LName { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public bool Status { get; set; }

        
        public Applier(int id, string email, string password, int maxRadius)
        {
            Id = id;
            Email = email;
            Password = password;
            MaxRadius = maxRadius;
        }
    }
}
