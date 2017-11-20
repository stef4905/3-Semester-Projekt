using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
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

        [OperationContract]
        Company Login(string email, string password);
    }
}