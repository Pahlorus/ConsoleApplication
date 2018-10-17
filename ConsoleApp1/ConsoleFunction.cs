using System;

namespace ConsoleApp1
{
    internal static class ConsoleFunction
    {
        internal static void StartText()
        {
            Console.WriteLine("Вывод сортированного списка работников - 1");
            Console.WriteLine("Вывод списка менеджеров - 2");
            Console.WriteLine("Вывод списка исполнителей - 3");
            Console.WriteLine("Вывод работника по ID - 4");
            Console.WriteLine("Ввод нового пользователя - 5");
            Console.WriteLine("Выход из приложения - Esc");
        }

        internal static void ReturnToStart()
        {
            Console.WriteLine();
            Console.WriteLine("Нажмите Space для возврата в меню");
            Console.WriteLine("Нажмите Esc для выхода");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                Console.Clear();
                StartText();
            }
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }

        internal static void InputHandler(WorkerDB workerDB)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.D1)
            {
                workerDB.GetSortedFullWorkerList();
                ReturnToStart();
                InputHandler(workerDB);
            }

            else if (key.Key == ConsoleKey.D2)
            {
                workerDB.GetManagerList();
                ReturnToStart();
                InputHandler(workerDB);
            }
            else if (key.Key == ConsoleKey.D3)
            {
                workerDB.GetEmployeeList();
                ReturnToStart();
                InputHandler(workerDB);
            }

            else if (key.Key == ConsoleKey.D4)
            {
                Console.WriteLine(" Введи ID работника (число), нажми Enter:");
                try
                {
                    int id = int.Parse(Console.ReadLine());
                    workerDB.GetWorkerFromId(id);
                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат ID");
                }
                ReturnToStart();
                InputHandler(workerDB);
            }

            else if (key.Key == ConsoleKey.D5)
            {
                Console.WriteLine(" Введи имя, нажми Enter:");
                string name = Console.ReadLine();
                Console.WriteLine(" Введи департамент, нажми Enter:");
                string department = Console.ReadLine();
                workerDB.AddNewWorker(name, department);
                Console.WriteLine("Работник добавлен в DB");
                ReturnToStart();
                InputHandler(workerDB);
            }

            else if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine(" Неверный ввод");
                ReturnToStart();
                InputHandler(workerDB);
            }
        }
    }
}
