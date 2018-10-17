
namespace ConsoleApp1
{
    abstract class Worker
    {
        protected  string _name;
        protected  string _position;

        public string Name
        {
            get { return _name; }
        }

        public string Position
        {
            get { return _position; }
        }

        public abstract void GetReport();
    }
}
