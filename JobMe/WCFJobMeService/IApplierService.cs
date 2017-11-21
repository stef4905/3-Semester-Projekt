using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFJobMeService
{
    /// <summary>
    /// You can use the "Rename" command on the "Refactor" menu 
    /// to change the interface name "IApplierService" in both code and config file together.
    /// </summary>
    [ServiceContract]
    public interface IApplierService
    {
        [OperationContract]
        void CreateApplier(Applier applier);

        [OperationContract]
        List<Applier> GetAllAppliers();

        [OperationContract]
        Applier GetApplier(int id);

        [OperationContract]
        Applier LoginApplier(string email, string password);

        [OperationContract]
        void UpdateApplier(Applier applier);

        [OperationContract]
        void CreateJobCV(JobCV jobCV, Applier applier);

        [OperationContract]
        void DeleteJobCV(int id);

        [OperationContract]
        JobCV GetJobCV(int id);

        [OperationContract]
        List<JobCV> GetAllJobCV();

        [OperationContract]
        void UpdateJobCV(JobCV obj);


    }

}
