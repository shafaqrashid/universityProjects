using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_free_number
{
    class Program
    {
        public static void Fibonacci(int input)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);

            for (int i = 2; i < input; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                
                a = b;
                b = c;
              

            }
            Console.ReadLine();
        }
    }
}

  