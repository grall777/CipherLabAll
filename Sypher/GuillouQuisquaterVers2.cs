using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sypher
{
    public class GuillouQuisquaterVers2
    {
        static BigInteger p = BigInteger.Parse("1180591620717411303424"); // простое число
        static BigInteger g = BigInteger.Parse("2"); // генератор группы
        static BigInteger x = BigInteger.Parse("123456789"); // закрытый ключ
        static BigInteger y = BigInteger.ModPow(g, x, p); // открытый ключ

        public void Cipher()
        {
            Console.Write("Введите сообщение: ");
            string message = Console.ReadLine();

            BigInteger k = GenerateRandomNumber(); // случайное число k
            BigInteger r = BigInteger.ModPow(g, k, p); // первая часть шифрованного сообщения
            BigInteger e = CalculateHash(message + r.ToString()); // хэш-функция от сообщения и первой части шифрованного сообщения
            BigInteger s = (k - x * e) % (p - 1); // вторая часть шифрованного сообщения

            Console.WriteLine("Зашифрованное сообщение: ({0}, {1})", r, s);

            Console.WriteLine("Введите первую часть зашифрованного сообщения:");
            BigInteger r1 = BigInteger.Parse(Console.ReadLine()); // ввод первой части зашифрованного сообщения
            Console.WriteLine("Введите вторую часть зашифрованного сообщения:");
            BigInteger s1 = BigInteger.Parse(Console.ReadLine()); // ввод второй части зашифрованного сообщения

            BigInteger e1 = CalculateHash(message + r1.ToString()); // хэш-функция от сообщения и первой части зашифрованного сообщения
            BigInteger v = BigInteger.ModPow(y, e1, p) * BigInteger.ModPow(r1, s1, p) % p; // проверка подписи

            if (v == r1)
            {
                Console.WriteLine("Подпись верна.");
            }
            else
            {
                Console.WriteLine("Подпись неверна.");
            }

            Console.ReadLine();
        }

        static BigInteger GenerateRandomNumber()
        {
            Random random = new Random();
            byte[] bytes = new byte[p.ToByteArray().Length];
            random.NextBytes(bytes);
            return new BigInteger(bytes) % (p - 2) + 1;
        }

        static BigInteger CalculateHash(string message)
        {
            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(message);
            BigInteger hash = 0;

            foreach (byte b in bytes)
            {
                hash = (hash * 256 + b) % (p - 1);
            }

            return hash;
        }
    }
}
