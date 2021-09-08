using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherConsole
{
    class Caesar
    {
        public string inputStr { get; set; }
        public int shiftKey { get; set; }

         public Caesar(string str, int key )
        {
            inputStr = str;
            shiftKey = key;
        }


        //Encode method
        public void Encode() {


            Console.Write(inputStr + "poo"+shiftKey);
            Console.WriteLine("");
            char temp;

            var sb = new StringBuilder();

            for (int i = 0; i < inputStr.Length; i++) {

                temp = (char)(inputStr[i] + shiftKey);
                sb.Append(temp);
            }
            Console.WriteLine(sb);

        }


    }
}
