using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkerDB workerDB = new WorkerDB();
            ConsoleFunction.StartText();
            ConsoleFunction.InputHandler(workerDB);
        }
    }
}
