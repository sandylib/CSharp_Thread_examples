using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Join_and_Thread_IsAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("main started");
            Thread T1 = new Thread(Program.Thread1Function);
            T1.Start();

            Thread T2 = new Thread(Program.Thread2Function);
            T2.Start();

            T1.Join(); 
            

            Console.WriteLine("Main complited");

            Console.ReadLine();

        }

        public static void Thread1Function()
        {
            Console.WriteLine("Thread1 Function started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 Function is about to return");
        }


        public static void Thread2Function()
        {
            Console.WriteLine("Thread2 Function started");
        }

    }




}
