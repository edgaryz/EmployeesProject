using EmployeesProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesProject.Contracts
{
    public interface IMongoDbRepository
    {
        //OfficeWorker
        Task<List<OfficeWorker>> GetOfficeWorkersList();
        Task<OfficeWorker> GetOfficeWorkerByLastName(string surName);
        Task InsertOfficeWorkersList(List<OfficeWorker> oWorkers);
        Task InsertOfficeWorker(OfficeWorker oWorker);

        //ProductionWorker
        Task<List<ProductionWorker>> GetProductionWorkersList();
        Task<ProductionWorker> GetProductionWorkerByLastName(string surName);
        Task InsertProductionWorkersList(List<ProductionWorker> pWorkers);
        Task InsertProductionWorker(ProductionWorker pWorker);
    }
}
