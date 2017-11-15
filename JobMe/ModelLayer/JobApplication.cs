using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ApplierId { get; set; }

        /// <summary>
        /// Job Application Model
        /// </summary>
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
