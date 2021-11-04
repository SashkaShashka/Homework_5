using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Book : IInventory
    {
        const int NumberOfType = 13;
        private static ulong countBook = 1;
        public string Number { get; private set; }
        public string Name { get; set; }
        public string Authors { get; set; } //наверное лучше список строк, но решил не заморачиваться
        public DateTime YearPublication { get; set; }
        public Book(DateTime year)
        {
            Number = ClassHelper.GetNumber(NumberOfType, countBook++, year);
        }
    }
}
