// unset

using SmartBarbequeMaker.Meat;
using System.Threading;
using static System.Console;

namespace SmartBarbequeMaker
{
    public class SmartBarbequeMaker
    {
        public AbstractMeat LoadedMeat { get; set; }

        public void CookPork()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill sets at 50 degrees for an 1 hour");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: Add the meat first");
        }

        public void CookChicken()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill sets at 40 degrees for 20 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        public void CookBeef()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("The Grill sets at 50 degrees for 30 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(500);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        private void Beeep()
        {
            WriteLine("\nBeeeep!!!");
            Beep(300, 1500);
        }

        private void TurnOn()
        {
            WriteLine("Grill turns on");
        }

        private void TurnOff()
        {
            WriteLine("Grill turns off");
        }

        private bool IsMeatLoaded()
        {
            return LoadedMeat != null;
        }
    }
}