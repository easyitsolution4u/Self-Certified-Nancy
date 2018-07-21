using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfSignedNancy
{
    class Program
    {
        private string _url = "https://localhost";
        private int _port = 12348;
        private NancyHost _nancy;

        public Program()
        {
            var uri = new Uri($"{_url}:{_port}/");


            //var configuration = new HostConfiguration()
            //{
            //    UrlReservations = new UrlReservations() { CreateAutomatically = true }
            //};
            _nancy = new NancyHost(uri);
        }

        private void Start()
        {
            _nancy.Start();
            Console.WriteLine($"Started listennig port {_port}");
            Console.ReadKey();
            _nancy.Stop();
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.Start();
        }
    }
}
