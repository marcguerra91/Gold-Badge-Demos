﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sum = AddWholeNumbers(2, 5);
            string input = Console.ReadLine();

            int choice = ParseInput();
        }

        static int AddWholeNumbers(int number1, int number2)
        {
            int number3 = number1 + number2;
            return number3;
        }

        static int ParseInput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }
    }
}
