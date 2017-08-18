using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random Number Generator

            Random rnd = new Random();
            int x = rnd.Next(1, 6);
            int y = rnd.Next(1, 6);
            int z = rnd.Next(1, 6);

            int a = x + y + z;

            Console.Write(a.ToString());

            Console.Read();


            //Random from list
            //List<string> asdf = new List<string>();

            //asdf.Add("one");
            //asdf.Add("two");
            //asdf.Add("three");
            //asdf.Add("four");
            //asdf.Add("five");

            //Random r = new Random();

            //int a = r.Next(asdf.Count);

            //Console.Write((string)asdf[a]);

            //Console.Read();
        }
    }
}
