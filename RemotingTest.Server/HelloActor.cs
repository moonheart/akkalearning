using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using RemotingTest.Common;

namespace RemotingTest.Server
{
    public class HelloActor : ReceiveActor
    {
        public HelloActor()
        {
            Receive<HelloMessage>(message =>
            {
                Console.WriteLine(message.Message);
            });
        }
    }
}
