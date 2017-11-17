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
        [DataMember]
        public string CurrentJob { get; set; }
        [DataMember]
        public DateTime Birthdate { get; set; }
        [DataMember]
        public List<JobCategory> jobCategoryList { get; set; }

        /// <summary>
        /// Constructor for Applier with the needed parameters.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="maxRadius"></param>
        public Applier(string email, string password, int maxRadius)
        {
            this.Email = email;
            this.Password = password;
            this.MaxRadius = maxRadius;
        }

        //Secondary empty constructor.
        public Applier()
        {

        }
    }
}
