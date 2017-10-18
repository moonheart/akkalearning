using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;

namespace RemotingTest.Server
{
    public class Program
    {
        static void Main()
        {
            using (var system = ActorSystem.Create("MyServer"))
            {
                system.ActorOf<HelloActor>("Greeting");

                Console.ReadLine();
            }
        }
    }
}
