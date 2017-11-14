using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class WorkHours
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Type { get; set; }
    }
}