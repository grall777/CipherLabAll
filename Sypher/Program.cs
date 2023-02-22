
namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {

            //ColumnCip cc = new ColumnCip();

            ColumnСipher cc = new ColumnСipher();

            cc.setKey("Пиво");
            cc.splitKey();
            cc.setText("Выпивать");
            cc.splitText();
            cc.findSize();

        }
    }
}