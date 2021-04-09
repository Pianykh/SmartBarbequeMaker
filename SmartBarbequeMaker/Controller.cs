
using SmartBarbequeMaker.Meat;
using System;
using static System.Console;

namespace SmartBarbequeMaker
{
    public static class Controller
    {
        public static void ShowMenu()
        {
            var barbecue = new SmartBarbequeMaker();

            while (true)
            {
                WriteLine("Choose action: 1. Load Meat in Grill 2. Press \"Pork\" 3. Press \"Chicken\" 4. Press\"Beef\"");
                
                switch (ReadLine())
                {
                    case "1":
                        barbecue.LoadedMeat = new Beef();
                        Console.WriteLine("Meat loaded");
                        break;
                    case "2":
                        barbecue.CookPork();
                        break;
                    case "3":
                        barbecue.CookChicken();
                        break;
                    case "4":
                        barbecue.CookBeef();
                        break;
                }
            }
        }
    }
}