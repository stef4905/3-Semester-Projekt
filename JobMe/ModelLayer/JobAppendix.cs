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
        public int Id { set; get; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string FilePath { get; set; }
        [DataMember]
        public int JobCVId { get; set; }


        /// <summary>
        /// Constructor with the the needed parameters for a JobAppendix
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="filePath"></param>
        /// <param name="jobCVId"></param>
        public JobAppendix(int id, string title, string filePath, int jobCVId)
        {
            this.Id = id;
            this.Title = title;
            this.FilePath = filePath;
            this.JobCVId = jobCVId;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public JobAppendix()
        {

        }
    }
}
