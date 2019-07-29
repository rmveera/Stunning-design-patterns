using System;

namespace SingletonDesignPattern
{
    public class EagerSingleton
    {
        private static EagerSingleton instance = new EagerSingleton();
        private string Name { get; set; }
        private string IP { get; set; }

        private EagerSingleton()
        {
            Name = "Server1";
            IP = "192.168.1.23";
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

        public static EagerSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public class LazySingleton
    {
        private static LazySingleton instance = null;
        private string Name { get; set; }
        private string IP { get; set; }

        private LazySingleton()
        {
            Name = "Server1";
            IP = "192.168.1.23";
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

        public static LazySingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new LazySingleton();

                return instance;
            }
        }
    }

    public class Singleton
    {
        private static Singleton instance = null;

        private string Name { get; set; }
        private string IP { get; set; }

        private Singleton()
        {
            Name = "Server1";
            IP = "192.168.1.23";
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }

        private static object lockThis = new object();

        public static Singleton Instance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                        instance = new Singleton();

                    return instance;
                }
            }
        }
    }
}