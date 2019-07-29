using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesignPattern
{
    public interface IClient
    {
        string GetData();
    }

    public class RealClient : IClient
    {
        private string Data;

        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            Data = "Dot Net Hacks";
        }

        public string GetData()
        {
            return Data;
        }
    }

    public class ProxyClient : IClient
    {
        private RealClient client = new RealClient();

        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return client.GetData();
        }
    }
}