using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Device : IInventory
    {
        const int NumberOfType = 3;
        private static ulong countDevice = 1;
        public string Number { get; }
        public Device(DateTime year)
        {
            Number = ClassHelper.GetNumber(NumberOfType, countDevice++, year);
        }
    }
}
