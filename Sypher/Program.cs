
namespace Sypher
{
    class Program
    {
        static void Main(string[] args)
        {
            ColumnСipher cc = new ColumnСipher();

            cc.setKey("Пиво");
            cc.splitKey();
            cc.setText("Выпивать");
            cc.splitText();
            cc.findSize();
            
        }
    }
}