using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class User
    {
        public int Id { get; set; }
        public string FName { get; set; }

        public User(int Id, string Fname)
        {
            this.Id = Id;
            this.FName = Fname;
        }
    }


}
