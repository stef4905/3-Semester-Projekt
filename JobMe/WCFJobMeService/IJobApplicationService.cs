using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLogicLayer;

namespace WCFJobMeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJobApplicationService" in both code and config file together.
    [ServiceContract]
    public interface IJobApplicationService
    {
        [OperationContract]
        void Create(JobApplication jobApplication);

        [OperationContract]
        JobApplication Get(int id);

        [OperationContract]
        List<JobApplication> GetAllByApplierId(int applierId);


    }
}
