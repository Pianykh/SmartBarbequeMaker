
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
                WriteLine("Choose action: 1. Load Meat in Grill 2. Press \"Pork\" " +
                          $"3. Press \"Chicken\" 4. Press\"Beef\"  {(barbecue.LoadedMeat != null ? "5. Get the meat out" : "")}");
                
                switch (ReadLine())
                {
                    case "1":
                        barbecue.LoadedMeat = new Beef();
                        WriteLine("Meat loaded");
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
                    case "5" when (barbecue.LoadedMeat != null) : barbecue.LoadedMeat = null;
                        WriteLine("The meat is pulled out");
                        break;
                    default:
                        Console.WriteLine("Incorrect operation");
                        break;
                }
            }
        }
    }
}