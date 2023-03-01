
namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Столбцовый шифр");
            ColumnСipher cc = new ColumnСipher();
            cc.setKey("криптография");
            cc.setText("перваялабораторнаяработапокиоки");
            cc.findSize();
            cc.findQueue();
            cc.encrypt(); // бблрирркртптпяяквниеооааааоооаа
            cc.decrypt("криптография", "бблрирркртптпяяквниеооааааоооаа");

            Console.WriteLine();

            Console.WriteLine("Шифр Цезаря:");
            CaesarCipher ca = new CaesarCipher();
            string text = ca.Encrypt("абв", 1);
            Console.WriteLine(text);
            text = ca.Decrypt(text, 1);
            Console.WriteLine(text);

        }
    }
}