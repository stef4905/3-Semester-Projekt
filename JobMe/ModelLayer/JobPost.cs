using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    [DataContract]
    public class JobPost
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public DateTime StartDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }
        [DataMember]
        public string JobTitle { get; set; }
        [DataMember]
        public WorkHours workHours  { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public Company company { get; set; }
        [DataMember]
        public JobCategory jobCategory { get; set; }

        /// <summary>
        /// Contructor for the JobPost calss
        /// Sets the required parameters for the JobPost Class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="jobTitle"></param>
        /// <param name="workHours"></param>
        /// <param name="address"></param>
        /// <param name="company"></param>
        /// <param name="jobCategory"></param>
        public JobPost(int id, string title, string description, DateTime startDate, DateTime endDate, string jobTitle, WorkHours workHours, string address, Company company, JobCategory jobCategory)
        {
           this.Id = id;
           this.Title = title;
           this.Description = description;
           this.StartDate = startDate;
           this.EndDate = endDate;
           this.JobTitle = jobTitle;
           this.workHours = workHours;
           this.Address = address;
           this.company = company;
           this.jobCategory = jobCategory;
        }
        public JobPost()
        {

        }
    }



}
