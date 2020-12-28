using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TransactionScope ts = new TransactionScope(TransactionScopeOption.Required))
            {
                Console.WriteLine("Pushing messages to DemoTx queue");
                localhost.Service1Client proxy = new localhost.Service1Client();
                int count;
                count = 1;
                proxy.SendMessage(string.Format("This is {0} message from client", count));
                count = 2;
                proxy.SendMessage(string.Format("This is {0} message from client", count));
                count = 3;
                proxy.SendMessage(string.Format("This is {0} message from client", count));
                count = 4;
                proxy.SendMessage(string.Format("This is {0} message from client", count));
                count = 5;
                proxy.SendMessage(string.Format("This is {0} message from client", count));
                ts.Complete();
                Console.WriteLine("Pushed messages to DemoTx queue");
            }
                
        }
    }
}
