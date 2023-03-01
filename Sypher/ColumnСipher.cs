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
        int[] keyNum;
        string[,] arrayText;
        

        public void setKey(string key)
        {
            this.key = key;
        }
        public void setText(string text)
        {
            this.text = text.Replace(" ", "");
        }
        public void findSize()
        {
            int width = key.Length;
            int high = text.Length / key.Length + 2;

           // Console.WriteLine(width);
           // Console.WriteLine(high);

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
                     //   Console.Write(arrTxt[i, j]);
                    }

                }
                //Console.WriteLine();
            }
            this.arrayText = arrTxt;
        }

        public void findQueue()
        {
            int[] keyNumBuff = new int[key.Length];
            int number = 0;
            for (int i = 'а'; i <= 'я'; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[j] == i)
                    {
                        keyNumBuff[j] = number;
                        number++;
                    }
                }
                
            }

            for (int i = 0; i < keyNumBuff.Length; i++)
            {
                //Console.Write(keyNumBuff[i] + " ");
            }

            this.keyNum = keyNumBuff;
        }

        public void encrypt()
        {
            int high = arrayText.GetLength(0);
            int width = arrayText.GetLength(1);
            string text = "";
            int buffer = 0;

            for (int i = 0; i < keyNum.Length; i++)
            {
                for (int j = 0; j < keyNum.Length; j++)
                {
                    if (i == keyNum[j])
                    {
                        for (int k = 0; k < high; k++)
                        {
                            text += arrayText[k,j];
                        }
                    }
                }
            }
          //  Console.WriteLine();
            Console.WriteLine(text);
        }

        public void decrypt(string key, string text)
        {
            setKey(key);
            setText(text);
            findQueue();
            findSize();
            int high = arrayText.GetLength(0);
            int width = arrayText.GetLength(1);
            int notFill = (high - 1) * width - text.Length;
            string decryptText = "";
            int buffer = 0;
            string[,] arrayDecrypt = new string[high, width];
            for (int i = 0; i < keyNum.Length; i++)
            {
                for (int j = 0; j < keyNum.Length; j++)
                {
                    if (i == keyNum[j])
                    {
                        if (j < width - notFill && buffer < text.Length - 1)
                        {
                            for (int k = 0; k < high - 1; k++)
                            {
                                
                                arrayDecrypt[k, j] = Convert.ToString(text[buffer]);
                                buffer++;
                              //  Console.WriteLine(arrayDecrypt[k,j] + k + j);
                            }
                        }
                        else if (j >= width - notFill && buffer < text.Length - 1)
                        {
                            for (int k = 0; k < high - 2; k++)
                            {
                                arrayDecrypt[k, j] = Convert.ToString(text[buffer]);
                                buffer++;
                                //Console.WriteLine(arrayDecrypt[k, j] + k + j);
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < arrayDecrypt.GetLength(0); i++)
            {
                for (int j = 0; j < arrayDecrypt.GetLength(1); j++)
                {
                    decryptText += arrayDecrypt[i, j];
                  //  Console.Write(arrayDecrypt[i,j]);
                }
                //Console.WriteLine();
            }
            Console.WriteLine(decryptText);

        }

    }
}
