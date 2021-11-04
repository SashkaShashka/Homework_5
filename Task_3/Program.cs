using System;
using System.Collections.Generic;

namespace Task_3
{
    class Program
    {
        static List<Object> objects = new List<object>()
        {
            new Computer(new DateTime(2021, 01, 01)),
            new Computer(new DateTime(2020, 01, 01)),
            new Computer(new DateTime(2019, 01, 01)),
            new Computer(new DateTime(2013, 01, 01)),
            new Book(new DateTime(1999, 01, 01)),
            new Book(new DateTime(1979, 01, 01)),
            new Book(new DateTime(2003, 01, 01)),
            new Book(new DateTime(2010, 01, 01)),
            new Building(new DateTime(1971, 01, 01)),
            new Building(new DateTime(1956, 01, 01)),
            new Building(new DateTime(1980, 01, 01)),
            new Building(new DateTime(1993, 01, 01)),
        };
        static void PrintNumber()
        {
            foreach (var item in objects)
            {
                Console.WriteLine((item as IInventory).Number);
            }
        }
        static void Main(string[] args)
        {
            PrintNumber();
        }
    }
}
