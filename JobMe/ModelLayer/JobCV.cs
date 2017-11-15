using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class JobCV
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int ApplierId { get; set; }
        [DataMember]
        public List<JobAppendix> JobAppendixList = new List<JobAppendix>();
        [DataMember]
        public List<JobExperience> JobExperienceList = new List<JobExperience>();

        /// <summary>
        /// Constructor for JobCV
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="applierId"></param>
        public JobCV(int id, string title, int applierId)
        {
            this.Id = id;
            this.Title = title;
            this.ApplierId = applierId;
        }
    }
}
