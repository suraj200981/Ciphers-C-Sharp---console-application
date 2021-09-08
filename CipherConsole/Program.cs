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
            string input = "hello how are you";
            var cipher1 = new Caesar(input, 3);


            cipher1.Encode();
            Console.ReadLine(); 
        }
    }
}
