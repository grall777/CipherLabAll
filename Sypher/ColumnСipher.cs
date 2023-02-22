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
            int x = charsKey.Length;
            int y;
            if (x > charsText.Length)
            {
                y = 3;
            }
            else
            {
                y = charsKey.Length / x + 2; // доделать
                //Math.Ceiling();
            }
            char[,] table = new char[y, x];

            for (int i = 0; i < x; i++)
            {
                table[0, i] = charsKey[i];
            }

            for (int i = 2; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    table[i, j] = charsText[j];
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }



    }
}
