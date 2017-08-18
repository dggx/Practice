using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        //Determine if a number is a power of 2
        static void Main(string[] args)
        {
            bool IsPowerOf2(int n)
            {
                return (n > 0) && ((n & (n - 1)) == 0);
            }

            for (int i = 0; i < 33; i++)
            {
                Console.WriteLine("{0} = {1}", i, IsPowerOf2(i));
            }
            Console.ReadLine();
        }
    }
}
