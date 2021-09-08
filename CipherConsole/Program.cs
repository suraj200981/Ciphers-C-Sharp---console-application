using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "drsc wocckqo sc rsnnox";
            var cipher1 = new Caesar(input, 10);


            Console.WriteLine(cipher1.Encode());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(cipher1.Decode());

            Console.ReadLine(); 
        }
    }
}
