﻿// unset

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
                WriteLine("Grill set 50 temperature and 1 hour");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(2000);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        public void CookChicken()
        {
            if (IsMeatLoaded())
            {
                TurnOn();
                WriteLine("Grill set 40 temperature and 20 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(2000);
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
                WriteLine("Grill set 60 temperature and 30 minutes");
                Thread.Sleep(2000);
                WriteLine("*Pshhhhhisssshhhhh*");
                for (var i = 0; i < 10; i++)
                {
                    Write(". ");
                    Thread.Sleep(200);
                }
                Thread.Sleep(2000);
                Beeep();
                TurnOff();
            }
            else
                WriteLine("Error: First need to load Meat");
        }

        private void Beeep()
        {
            WriteLine("\nBeeeep!!!");
            Beep(150, 1500);
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