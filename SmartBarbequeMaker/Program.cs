using System;
using System.Text;

namespace SmartBarbequeMaker
{
    static class Program
    {
        private static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Controller.ShowMenu();
        }
    }
}
