
namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {
            ColumnСipher cc = new ColumnСipher();
            cc.setKey("криптография");
            cc.setText("перваялабораторнаяработапокиоки");
            cc.findSize();
            cc.findQueue();
            cc.encrypt(); // бблрирркртптпяяквниеооааааоооаа
            cc.decrypt("криптография", "бблрирркртптпяяквниеооааааоооаа");

            //CipherColumn ts = new CipherColumn();
            //int[] key = ts.findQueue("абв");
            //ts.SetKey("5 8 3 7 10 6 2 9 1 11 4 12");
            //string text = ts.Encrypt("перваялабораторнаяработапокиоки");
            //Console.WriteLine(text);
            //string text1 = ts.Decrypt(text);
            //Console.WriteLine(text1);

        }
    }
}