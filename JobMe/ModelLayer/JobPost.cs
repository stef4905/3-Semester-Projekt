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

        public JobPost(string title, string description, DateTime startDate, DateTime endDate, string jobTitle, WorkHours workHours, string address, Company company, JobCategory jobCategory)
        {

            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            JobTitle = jobTitle;
            this.workHours = workHours;
            Address = address;
            this.company = company;
            this.jobCategory = jobCategory;
        }
    }



}
