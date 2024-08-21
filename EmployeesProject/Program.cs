using EmployeesProject.Contracts;
using EmployeesProject.Models;
using EmployeesProject.Repositories;
using EmployeesProject.Services;
using MongoDB.Driver;

namespace EmployeesProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEmployeesService employeesService = SetupDependencies();
            /*            ProductionWorker newPWorker = new ProductionWorker();
                        newPWorker.Name = "Rayko";
                        newPWorker.SurName = "Jugger";
                        newPWorker.Age = 25;
                        newPWorker.Shift = "Night";
                        employeesService.InsertProductionWorker(newPWorker);*/

            employeesService.GetProductionWorkersList();

        }

        public static IEmployeesService SetupDependencies()
        {
            IMongoDbRepository mongoDbRepository = new MongoDbRepository(new MongoClient("mongodb+srv://edgarsokol:lala4444@cluster0.kdpdd.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"));
            return new EmployeesService(mongoDbRepository);
        }
    }
}