using System;
using System.Text;

namespace SmartBarbequeMaker
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Controller.ShowMenu();
        }
    }
}
