using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WorkerDB
    {
        private Dictionary<int, Worker> _workerDictionary;

        internal WorkerDB()
        {
            _workerDictionary = new Dictionary<int, Worker>()
            {
                {0, new Manager("Алекс", "Пылесосы")},
                {1, new Employee("Петр")},
                {2, new Employee("Степан")},
                {3, new Manager("Павел", "Телевизоры")},
                {4, new Employee("Николай")},
                {5, new Employee("Константин")},
                {6, new Manager("Татьяна", "Посуда")},
                {7, new Employee("Михаил")},
                {8, new Employee("Авдотья")},
                {9, new Employee("Матрена")},
            };
        }

        internal void AddNewWorker(string name, string department)
        {
            Console.Clear();
            Worker newWorker;
            if (string.IsNullOrEmpty(department))
            {
                newWorker = new Employee(name);
            }
            else
            {
                newWorker = new Manager(name, department);
            }

            int maxIndex = _workerDictionary.Aggregate((keyValue1, keyValue2) => keyValue1.Key > keyValue2.Key ? keyValue1 : keyValue2).Key;
            _workerDictionary.Add(maxIndex + 1, newWorker);
        }

        internal void GetSortedFullWorkerList()
        {
            Console.Clear();
            List<Worker> workers = _workerDictionary.OrderBy(keyValue => keyValue.Value.Name).Select(keyValue => keyValue.Value).ToList();
            foreach (Worker worker in workers)
            {
                worker.GetReport();
            }
        }

        internal void GetManagerList()
        {
            Console.Clear();
            List<Worker> workers = _workerDictionary.Where(keyValue => keyValue.Value.Position == "Менеджер").Select(keyValue => keyValue.Value).ToList();
            foreach (Worker worker in workers)
            {
                worker.GetReport();
            }
        }

        internal void GetEmployeeList()
        {
            Console.Clear();
            List<Worker> workers = _workerDictionary.Where(keyValue => keyValue.Value.Position == "Исполнитель").Select(keyValue => keyValue.Value).ToList();
            foreach (Worker worker in workers)
            {
                worker.GetReport();
            }
        }

        internal void GetWorkerFromId(int workerId)
        {
            Console.Clear();
            List<Worker> workers = _workerDictionary.Where(keyValue => keyValue.Key == workerId).Select(keyValue => keyValue.Value).ToList();
            if (workers.Count > 0)
            {
                foreach (var worker in workers)
                {
                    worker.GetReport();
                }
            }
            else
            {
                Console.WriteLine("Указанного ID не существует");
            }
        }
    }
}
