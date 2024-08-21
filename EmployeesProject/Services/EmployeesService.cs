using EmployeesProject.Contracts;
using EmployeesProject.Models;

namespace EmployeesProject.Services
{
    public class EmployeesService : IEmployeesService
    {
        private readonly IMongoDbRepository _mongoDbRepository;

        public EmployeesService(IMongoDbRepository mongoDbRepository)
        {
            _mongoDbRepository = mongoDbRepository;
        }

        //OfficeWorker
        public async Task<List<OfficeWorker>> GetOfficeWorkersList()
        {
            return await _mongoDbRepository.GetOfficeWorkersList();
        }

        public async Task<OfficeWorker> GetOfficeWorkerByLastName(string surName)
        {
            return await _mongoDbRepository.GetOfficeWorkerByLastName(surName);
        }

        public async Task InsertOfficeWorkersList(List<OfficeWorker> oWorkers)
        {
            await _mongoDbRepository.InsertOfficeWorkersList(oWorkers);
        }

        public async Task InsertOfficeWorker(OfficeWorker oWorker)
        {
            await _mongoDbRepository.InsertOfficeWorker(oWorker);
        }

        //ProductionWorker
        public async Task<List<ProductionWorker>> GetProductionWorkersList()
        {
            return await _mongoDbRepository.GetProductionWorkersList();
        }

        public async Task<ProductionWorker> GetProductionWorkerByLastName(string surName)
        {
            return await _mongoDbRepository.GetProductionWorkerByLastName(surName);
        }

        public async Task InsertProductionWorkersList(List<ProductionWorker> pWorkers)
        {
            await _mongoDbRepository.InsertProductionWorkersList(pWorkers);
        }

        public async Task InsertProductionWorker(ProductionWorker pWorker)
        {
            await _mongoDbRepository.InsertProductionWorker(pWorker);
        }
    }
}
