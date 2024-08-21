using EmployeesProject.Contracts;
using EmployeesProject.Models;
using EmployeesProject.Repositories;
using EmployeesProject.Services;
using MongoDB.Driver;
using System.Diagnostics;

namespace EmployeesProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IEmployeesService employeesService = SetupDependencies();
            while (true)
            {
                Console.WriteLine("1. Office Workers Menu");
                Console.WriteLine("2. Production Workers Menu");
                Console.WriteLine("0. Exit Program");
                string mainMenu = Console.ReadLine();
                switch (mainMenu)
                {
                    case "0":
                        //Exit Program
                        return;
                    case "1":
                        Console.WriteLine("1. Office Workers List");
                        Console.WriteLine("2. Add OfficeWorker");
                        string choiceOfficeWorkers = Console.ReadLine();
                        switch (choiceOfficeWorkers)
                        {
                            case "0":
                                //Main Menu
                                break;
                            case "1":
                                //OfficeWorker
                                var OfficeWorkerList = employeesService.GetOfficeWorkersList();
                                foreach (OfficeWorker officeWorker in OfficeWorkerList.Result)
                                {
                                    Console.WriteLine(officeWorker);
                                }
                                break;
                            case "2":
                                //InsertOfficeWorker
                                OfficeWorker newOfficeWorker = new OfficeWorker();
                                Console.WriteLine("Enter OfficeWorker name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter OfficeWorker surName");
                                string surName = Console.ReadLine();
                                Console.WriteLine("Enter OfficeWorker age");
                                int age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter OfficeWorker department");
                                string department = Console.ReadLine();
                                newOfficeWorker = new OfficeWorker(name, surName, age, department);
                                employeesService.InsertOfficeWorker(newOfficeWorker);
                                Console.WriteLine("OfficeWorker creation successful!");
                                break;
                        }
                        break;
                    case "2":
                        Console.WriteLine("1. Production Workers List");
                        Console.WriteLine("2. Add ProductionWorker");
                        string choiceProductionWorkers = Console.ReadLine();
                        switch (choiceProductionWorkers)
                        {
                            case "0":
                                //Main Menu
                                break;
                            case "1":
                                //GetAllProductionWorkers
                                var ProductionWorkerList = employeesService.GetProductionWorkersList();
                                foreach (ProductionWorker productionWorker in ProductionWorkerList.Result)
                                {
                                    Console.WriteLine(productionWorker);
                                }
                                break;
                            case "2":
                                //InsertProductionWorker
                                ProductionWorker newProductionWorker = new ProductionWorker();
                                Console.WriteLine("Enter ProductionWorker name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter ProductionWorker surName");
                                string surName = Console.ReadLine();
                                Console.WriteLine("Enter ProductionWorker age");
                                int age = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter ProductionWorker shift");
                                string shift = Console.ReadLine();
                                newProductionWorker = new ProductionWorker(name, surName, age, shift);
                                employeesService.InsertProductionWorker(newProductionWorker);
                                Console.WriteLine("ProductionWorker creation successful!");
                                break;
                        }
                        break;
                }
            }

        }

        public static IEmployeesService SetupDependencies()
        {
            IMongoDbRepository mongoDbRepository = new MongoDbRepository(new MongoClient("mongodb+srv://edgarsokol:lala4444@cluster0.kdpdd.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0"));
            return new EmployeesService(mongoDbRepository);
        }
    }
}