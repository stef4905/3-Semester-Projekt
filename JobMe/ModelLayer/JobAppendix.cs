using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class JobAppendix
    {
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string FilePath { get; set; }
    }
}
