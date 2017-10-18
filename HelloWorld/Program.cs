using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var system = ActorSystem.Create("MySystem");
            var greeter = system.ActorOf(Props.Create(() => new GreetingActor()), "greeter");
            greeter.Tell(new GreetingActor.GreetingMessage());

            Console.Read();
        }
    }
}
