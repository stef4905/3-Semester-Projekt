using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFJobMe
{
    [ServiceContract]
    public interface ICompanyService
    {

        [OperationContract]
        void Create(Company company);

        [OperationContract]
        void CreateJobPost(JobPost jobPost);

        [OperationContract]
        List<WorkHours> GetlAllWorkHours();

        [OperationContract]
        List<JobCategory> GetAllJobCategories();
    }
}
