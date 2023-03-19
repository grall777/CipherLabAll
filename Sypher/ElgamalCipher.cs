using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sypher
{
    public class ElgamalCipher
    {
        public void Encrypt()
        {
            int M = 5;
            Console.WriteLine("Message: " + M);
            Random rnd = new Random();
            int value = rnd.Next(0, 12);
            int[] simpleNumber = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 
                41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97};
            int p = simpleNumber[value];
            int g = 7;



            List<int> randomList = new List<int>();
            for (int i = 2; i < p - 1; i++)
            {
                randomList.Add(i);
            }
            int x = randomList[rnd.Next(0, randomList.Count)];
            double y = Math.Pow(g, x) % p;
            int k = 0;
            for (int i = 2; i < p - 1; i++)
            {
                if (find(i, p - 1) == 1)
                {
                    k = i;
                    break;
                }
            }
            double a = (Math.Pow(g, k)) % p;
            double b = (Math.Pow(y, k)) * M % p;
            double message = Decrypt(a, b, x, p);
            Console.WriteLine("CipherText:(" + a + "," + b + ")");
            Console.WriteLine("Key: " + a + " " + b + " " + x + " " + p);
            Console.WriteLine("DecryptText: " + message);
        }

        public double Decrypt(double a, double b, int x, int p)
        {
            double m = (b * (Math.Pow(a, p - 1 - x))) % p;
            return m;
        }

        private int find(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                while (b != 0)
                {
                    if (a > b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                return a;
            }

        }
    }
}

