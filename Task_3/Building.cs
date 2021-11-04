using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Building : IInventory
    {
        const int NumberOfType = 1;
        private static ulong countBuilding = 1;
        public string Adress { get; set; }
        public string Number { get; private set; }
        public Building(DateTime year)
        {
            Number = ClassHelper.GetNumber(NumberOfType, countBuilding++, year);
        }
    }
}
