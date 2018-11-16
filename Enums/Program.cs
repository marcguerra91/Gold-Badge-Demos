using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Dragons dragon = new Dragons()
            {
                BreathesFire = true,
                IsScary = false,
                AmountOfGold = 2000,
                TypeOfDragon = DragonType.Red,
            };

            Console.WriteLine("What type of dragon do you want?\n" +
                "1.Red\n" +
                "2.Gold\n" +
                "3.Elder\n" +
                "4.Frost\n" +
                "5.Blue\n");
            var dragonInput = Console.ReadLine();
            switch (dragonInput)
            {
                default:
                    break;
            }

        }
    }
}
