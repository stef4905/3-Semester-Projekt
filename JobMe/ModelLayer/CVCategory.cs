using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    /// <summary>
    /// Hvad skal den bruges til??????
    /// </summary>
    [DataContract]
    public class CVCategory
    {
        [DataMember]
        public string Title { get; set; }
    }
}
