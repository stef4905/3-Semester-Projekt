using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class User
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FName { get; set; }

       
        public User(int Id, string Fname)
        {
            this.Id = Id;
            this.FName = Fname;
        }
    }


}
