﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_List_Example
{
    class Person
    {
        public string FullName { get; set; }
        public List<Car> CarList { get; set; }

        public Person(string name, List<Car> carList)
        {
            FullName = name;
            CarList = carList;
        }

        public Person()
        {
            CarList = new List<Car>();
        }
    }
}
