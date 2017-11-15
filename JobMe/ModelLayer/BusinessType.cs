using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class BusinessType
    {
        public int Id { get; set; }

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
