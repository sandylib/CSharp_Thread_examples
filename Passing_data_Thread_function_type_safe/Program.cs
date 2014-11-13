using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Passing_data_Thread_function_type_safe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);
            Thread T1 = new Thread(new ThreadStart(number.PrintNumber));
            T1.Start();

            Console.ReadLine();
        }
    }

    class Number
    {
        int _target;
        public Number(int target)
        {
            this._target = target;
        }

        public void PrintNumber()
        {
            for(int i=1;i<=_target;i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
