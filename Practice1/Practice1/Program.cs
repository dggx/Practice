using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given: words = ['one', 'one', 'two', 'three', 'three', 'two']
//Remove the duplicates.
namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            words.Add("one");
            words.Add("one");
            words.Add("two");
            words.Add("three");
            words.Add("three");
            words.Add("two");

            foreach (string value in words)
            {
                Console.WriteLine("Before: {0}", value);
            }

            List<string> distinct = words.Distinct().ToList();

            foreach (string value in distinct)
            {
                Console.WriteLine("After: {0}", value);
            }

            Console.ReadLine();
        }
    }
}
