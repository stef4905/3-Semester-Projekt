using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class BusinessType
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Type { get; set; }

        /// <summary>
        /// Constructor for BusinessType
        /// </summary>
        /// <param name="id"></param>
        /// <param name="type"></param>
        public BusinessType(int id, string type)
        {
            this.Id = id;
            this.Type = type;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public BusinessType()
        {

        }
    }
}
