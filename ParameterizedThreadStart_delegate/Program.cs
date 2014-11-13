using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParameterizedThreadStart_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();
            Number number = new Number();

            Thread t1 = new Thread(number.PrintNumbers);
            t1.Start(target);

            Console.ReadLine();
        }


        class Number
        {
            public void PrintNumbers(object target)
            {
                int number = 0;
                if (int.TryParse(target.ToString(), out number))
                {
                    for (int i = 1; i <= number; i++)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
