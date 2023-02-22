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
            this.text = text;
        }
        public void splitText()
        {
            charsText = text.ToCharArray();
            
        }

        public void findSize()
        {

        }

        public void findSize()
        {
            int width = charsKey.Length;
            int high;
            if (width > charsText.Length)
            {
                high = 3;
            }
            else
            {
                high = charsKey.Length / width + 2; // доделать
                //Math.Ceiling();
            }
            char[,] table = new char[high, width];

            for (int i = 0; i < width; i++)
            {
                table[0, i] = charsKey[i];
            }

            for (int i = 2; i < high; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    table[i, j] = charsText[j];
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



    }
}
