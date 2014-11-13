using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStart_delegate
{
    /*
     * Why a delegate need to be passed as a parameter to the Thread class constructor?
     * 
     * The purpose of creating a Thread is to execute a function.A delegate is a type safe
     * function pointer,meaning it points to a function that the thread has to execute.
     * In short, all threads require an entry point to start execution. Any thread you create
     * will need an explicitly defined entry point i.e a pointer to the function where they should
     * begin execution.So threads always require a delegate.
     * 
     * */
    class Program
    {
        static void Main(string[] args)
        {
            //Thread T1 = new Thread(Number.PrintNumbers);//this is same like below
           // Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));

           // Thread T1 = new Thread(delegate() { Number.PrintNumbers(); });
            Thread T1 = new Thread(()=> Number.PrintNumbers()); //use lamda expression
            T1.Start();

            Console.ReadLine();
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
            }


        }
    }
}
