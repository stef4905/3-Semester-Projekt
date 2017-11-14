using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class JobCategory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
    }
}