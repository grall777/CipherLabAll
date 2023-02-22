using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sypher
{
    class ColumnСipher
    {
        string key;
        string text;
        char[] charsKey;
        char[] charsText;
        int[] keyNum;
        string[,] arrayText;
        

        public void setKey(string key)
        {
            this.key = key;
        }
        public void splitKey()
        {
            charsKey = key.ToCharArray();
        }
        public void setText(string text)
        {
            this.text = text.Replace(" ", "");
        }
        public void splitText()
        {
            charsText = text.ToCharArray();
        }

        public void findSize()
        {
            int width = charsKey.Length;
            int high = charsText.Length / charsKey.Length + 2;

            Console.WriteLine(width);
            Console.WriteLine(high);

            int buffer = 0;

            string[,] arrTxt = new string[high, width];

            for (int i = 0; i < high; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (buffer < text.Length)
                    {
                        arrTxt[i, j] = Convert.ToString(text[buffer]);
                        buffer++;
                        Console.Write(arrTxt[i, j]);
                    }

                }
                Console.WriteLine();
            }
            this.arrayText = arrTxt;
        }

        public void findQueue()
        {
            
        }




    }
}
