﻿using System;
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
        /// <param name="ApplierId"></param>
        public JobApplication(string title, string description, int ApplierId)
        {
            this.Title = title;
            this.Description = description;
            this.ApplierId = ApplierId;
        }
    }
}
