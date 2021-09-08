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
            inputStr = str.ToLower();
            shiftKey = key;
        }


        //Encode method
        public void Encode() {


            Console.Write("Original Cipher: "+inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();

            for (int i = 0; i < inputStr.Length; i++) {



                if (inputStr[i] != ' ')
                {
                    temp = (char)(inputStr[i] + shiftKey); //shift the char by the key amound and this will be the new shifted value


                    if (temp > 'z')
                    { // if surpasses z in alphabet in mod will wrap it round
                        temp = (char)(inputStr[i] - (26 - shiftKey % 26));
                    }

                    sb.Append(temp);

                }
                else {
                    sb.Append(" ");

                }



            }
            Console.WriteLine("Encoded as: "+ sb);

        }


    }
}
