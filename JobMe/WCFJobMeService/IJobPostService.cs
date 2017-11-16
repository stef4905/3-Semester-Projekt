using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJobPostService" in both code and config file together.
    [ServiceContract]
    public interface IJobPostService
    {
        [OperationContract]
        List<JobPost> GetAllJobPost();

        [OperationContract]
        void CreateJobPost(JobPost jobPost);

        [OperationContract]
        List<WorkHours> GetlAllWorkHours();

        [OperationContract]
        List<JobCategory> GetAllJobCategories();

        [OperationContract]
        JobPost Get(int id);
    }
}