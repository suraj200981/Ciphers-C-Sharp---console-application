namespace CipherConsole
{
    using System;
    using System.Text;

    /// <summary>
    /// Defines the <see cref="Caesar" />.
    /// </summary>
    internal class Caesar
    {
        /// <summary>
        /// Gets or sets the inputStr.
        /// </summary>
        public string inputStr { get; set; }

        /// <summary>
        /// Gets or sets the shiftKey.
        /// </summary>
        public int shiftKey { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Caesar"/> class.
        /// </summary>
        /// <param name="str">The str<see cref="string"/>.</param>
        /// <param name="key">The key<see cref="int"/>.</param>
        public Caesar(string str, int key)
        {
            inputStr = str.ToLower();
            shiftKey = key;
        }

        /// <summary>
        /// The Encode.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string Encode()
        {
            Console.Write("Original Cipher: " + inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();

            for (int i = 0; i < inputStr.Length; i++)
            {

                if (inputStr[i] != ' ')
                {
                    temp = (char)(inputStr[i] + shiftKey); //shift the char by the key amound and this will be the new shifted value


                    if (temp > 'z')
                    { // if surpasses z in alphabet in mod will wrap it round
                        temp = (char)(inputStr[i] - (26 - shiftKey % 26));
                    }

                    sb.Append(temp);

                }
                else
                {
                    sb.Append(" ");

                }

            }
            return "Encoded as: " + sb;
        }

        public string Decode() {
            int newKey = 26 - (shiftKey % 26);
            Console.Write("Original Cipher: " + inputStr);
            Console.WriteLine("");
            char temp;
            var sb = new StringBuilder();


            for (int i = 0; i < inputStr.Length; i++)
            {

                if (inputStr[i] != ' ')
                {
                    temp = (char)(inputStr[i] + newKey); //shift the char by the key amound and this will be the new shifted value


                    if (temp > 'z')
                    { // if surpasses z in alphabet in mod will wrap it round
                        temp = (char)(inputStr[i] - (26 - newKey % 26));
                    }

                    sb.Append(temp);

                }
                else
                {
                    sb.Append(" ");

                }

            }
            return "Decoded as: " + sb;
        }
    }
}
