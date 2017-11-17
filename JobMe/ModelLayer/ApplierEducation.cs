using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelLayer
{
    [DataContract]
    public class ApplierEducation
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string EducationName { get; set; }
        [DataMember]
        public string Institution { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public int JobCVId { get; set; }


        /// <summary>
        /// Creator for ApplierEducation with the given parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="educationName"></param>
        /// <param name="institution"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="jobCVId"></param>
        public ApplierEducation(int id, string educationName, string institution, DateTime startDate, DateTime endDate, int jobCVId)
        {
            this.id = id;
            this.EducationName = educationName;
            this.Institution = institution;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.JobCVId = jobCVId;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public ApplierEducation()
        {

        }
    }
}
