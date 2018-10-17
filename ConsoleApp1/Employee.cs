using System;

namespace ConsoleApp1
{
    internal class Employee : Worker
    {
        public Employee(string name)
        {
            _name = name;
            _position = "Исполнитель";
        }

        public override void GetReport()
        {
            Console.WriteLine(_name + ", " + _position);
        }
    }
}
