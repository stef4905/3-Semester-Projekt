using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJobCVService" in both code and config file together.
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
