using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace HelloWorld
{
    public class GreetingActor : ReceiveActor
    {
        public class GreetingMessage
        {
        }

        public GreetingActor()
        {
            Receive<GreetingMessage>(greet => Console.WriteLine("Hello World"));
        }
    }
}
