using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ModelLayer;

namespace WCFJobMeService
{
    [ServiceContract]
    public interface IJobCVService
    {
        [OperationContract]
        void Create(JobCV jobCV);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        JobCV Get(int applierId);

        [OperationContract]
        List<JobCV> GetAll();

        [OperationContract]
        void Update(JobCV obj);
    }
}
