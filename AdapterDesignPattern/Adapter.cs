using System;

namespace AdapterDesignPattern
{
    public class Client
    {
        private IAdapterTarget target;

        public Client(IAdapterTarget target)
        {
            this.target = target;
        }

        public void MakeRequest()
        {
            target.Display();
        }
    }

    public interface IAdapterTarget
    {
        void Display();
    }

    public class Adapter : Adaptee, IAdapterTarget
    {
        public void Display()
        {
            Display2();
        }
    }

    public class Adaptee
    {
        public void Display2()
        {
            Console.WriteLine("Display2() is called");
        }
    }
}