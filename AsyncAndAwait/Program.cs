using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProceduralMethodExecution();
            ThreadedMethodExecution();
            Console.ReadLine();
        }

       static void ProceduralMethodExecution()
       {
           Method();
           Console.WriteLine("Main Thread");
       }

        private static void Method()
        {
            Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }

        static void ThreadedMethodExecution()
        {
            ThreadedMethod();
            Console.WriteLine("Main Thread");
        }

        private static async void ThreadedMethod()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }
        private static void LongTask()
        {
            Thread.Sleep(10000);
        }
    }
}
