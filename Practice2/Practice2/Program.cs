using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a function that prints the numbers from 1 to 100.
//But for multiples of three print "T" instead of the number and
//for the multiples of five print "F".
//For numbers which are multiples of both three and five print "FooF".
namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            int b = 3;
            int c = 5;
            for (int i = 1; i < 101; i++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine("TF");
                }
                else if (i % b == 0)
                {
                    Console.WriteLine("T");
                }
                else if (i % c == 0)
                {
                    Console.WriteLine("F");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
