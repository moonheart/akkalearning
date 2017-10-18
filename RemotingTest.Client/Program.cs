using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Configuration;
using RemotingTest.Common;

namespace RemotingTest.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("MyClient"))
            {
                var greeting = system.ActorSelection("akka.tcp://MyServer@127.0.0.1:8081/user/Greeting");

                while (true)
                {
                    var input = Console.ReadLine();
                        greeting.Tell(new HelloMessage(){Message = $"{DateTime.Now}: {input}"});
                }
            }
        }
    }
}
