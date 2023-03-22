
using System.Text;

namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Столбцовый шифр");
            //ColumnСipher cc = new ColumnСipher();
            //cc.setKey("криптография");
            //cc.setText("перваялабораторнаяработапокиоки");
            //cc.findSize();
            //cc.findQueue();
            //cc.encrypt(); // бблрирркртптпяяквниеооааааоооаа
            //cc.decrypt("криптография", "бблрирркртптпяяквниеооааааоооаа");

            //Console.WriteLine();

            //Console.WriteLine("Шифр Цезаря:");
            //CaesarCipher ca = new CaesarCipher();
            //string text = ca.Encrypt("абв", 1);
            //Console.WriteLine(text);
            //text = ca.Decrypt(text, 1);
            //Console.WriteLine(text);


            //Console.WriteLine();
            //Console.WriteLine("Шифр Elgamal:");
            //ElgamalCipher el = new ElgamalCipher();
            //el.Encrypt();

            GuillouQuisquater GQ = new GuillouQuisquater();
            byte[] message = Encoding.UTF8.GetBytes("21");
            byte[] encryptedMessage = GQ.Encrypt(message);
            string encryptedString = Encoding.UTF8.GetString(encryptedMessage);
            Console.WriteLine(encryptedString);
            byte[] decryptedMessage = GQ.Decrypt(encryptedMessage);
            string decryptedString = Encoding.UTF8.GetString(decryptedMessage);
            Console.WriteLine(decryptedString);


        }
    }
}