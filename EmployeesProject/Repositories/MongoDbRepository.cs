using EmployeesProject.Contracts;
using EmployeesProject.Models;
using MongoDB.Driver;

namespace EmployeesProject.Repositories
{
    public class MongoDbRepository : IMongoDbRepository
    {
        private IMongoCollection<OfficeWorker> _officeWorkers;
        private IMongoCollection<ProductionWorker> _productionWorkers;
        public MongoDbRepository(IMongoClient mongoClient)
        {
            _officeWorkers = mongoClient.GetDatabase("office_workers").GetCollection<OfficeWorker>("office_workers");
            _productionWorkers = mongoClient.GetDatabase("production_workers").GetCollection<ProductionWorker>("production_workers");
        }

        //OfficeWorker
        public async Task<List<OfficeWorker>> GetOfficeWorkersList()
        {
            return await _officeWorkers.Find<OfficeWorker>(x => true).ToListAsync();
        }

        public async Task<OfficeWorker> GetOfficeWorkerByLastName(string surName)
        {
            try
            {
                return (await _officeWorkers.FindAsync<OfficeWorker>(x => x.SurName == surName)).First();
            }
            catch
            {
                return null;
            }
        }

        public async Task InsertOfficeWorkersList(List<OfficeWorker> oWorkers)
        {
            await _officeWorkers.InsertManyAsync(oWorkers);
        }

        public async Task InsertOfficeWorker(OfficeWorker oWorker)
        {
            await _officeWorkers.InsertOneAsync(oWorker);
        }

        //ProductionWorker
        public async Task<List<ProductionWorker>> GetProductionWorkersList()
        {
            return await _productionWorkers.Find<ProductionWorker>(x => true).ToListAsync();
        }

        public async Task<ProductionWorker> GetProductionWorkerByLastName(string surName)
        {
            try
            {
                return (await _productionWorkers.FindAsync<ProductionWorker>(x => x.SurName == surName)).First();
            }
            catch
            {
                return null;
            }
        }

        public async Task InsertProductionWorkersList(List<ProductionWorker> pWorkers)
        {
            await _productionWorkers.InsertManyAsync(pWorkers);
        }

        public async Task InsertProductionWorker(ProductionWorker pWorker)
        {
            await _productionWorkers.InsertOneAsync(pWorker);
        }
    }
}
