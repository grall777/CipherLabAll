
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
            cc.setText("Выпивать пиво плохо для здоровья человеков");
            cc.splitText();
            cc.findSize();

        }
    }
}