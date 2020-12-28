using System;
using System.ServiceModel;
using System.Messaging;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string queue = ".\\private$\\DemoTx";
            if(!MessageQueue.Exists(queue))
                MessageQueue.Create(queue, true);

            ServiceHost sh = new ServiceHost(typeof(DemoLibrary.Service1));
            sh.Open();
            Console.WriteLine("Server Started");
            Console.WriteLine("Press any key to stop the server");
            Console.ReadKey();
            Console.WriteLine("Server Stopped");
        }
    }
}
