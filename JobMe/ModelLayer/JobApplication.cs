using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class JobApplication
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int ApplierId { get; set; }

        /// <summary>
        /// Job Application Model
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="applierId"></param>
        public JobApplication(int id, string title, string description, int applierId)
        {
            this.Id = id;
            this.Title = title;
            this.Description = description;
            this.ApplierId = applierId;
        }
    }
}
