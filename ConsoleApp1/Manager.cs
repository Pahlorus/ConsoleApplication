using System;

namespace ConsoleApp1
{
    internal class Manager : Worker
    {
        protected string _direction;

        public Manager(string name, string direction)
        {
            _name = name;
            _position = "Менеджер";
            _direction = direction;
        }

        public override void GetReport()
        {
            Console.WriteLine(_name + ", " + _position + ", руководитель направления - " + _direction);
        }

    }
}
