using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class JobCV
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ApplierId { get; set; }
        public List<JobAppendix> JobAppendixList = new List<JobAppendix>();
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
