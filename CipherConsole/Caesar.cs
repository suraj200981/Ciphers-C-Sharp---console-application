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


            Console.Write("Original Cipher: "+inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();

            for (int i = 0; i < inputStr.Length; i++) {

                    temp = (char)(inputStr[i] +shiftKey );


                    if (temp > 'z')
                    {
                        temp = (char)(inputStr[i] - (26- shiftKey%26));

                        sb.Append(temp);
                    }
               
            }
            Console.WriteLine("Encoded as: "+ sb);

        }


    }
}
