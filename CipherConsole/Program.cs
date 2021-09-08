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
            string input = "THIS MESSAGE IS HIDDEN";
            var cipher1 = new Caesar(input, 10);


            cipher1.Encode();
            Console.ReadLine(); 
        }
    }
}
