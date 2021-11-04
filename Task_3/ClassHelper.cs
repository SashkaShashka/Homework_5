using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    static class ClassHelper
    {
        private static ulong number = 1;
        public static string GetNumber(uint type, ulong numberOfType, DateTime year)
        {
            if (type.ToString().Length > 2)
                throw new ArgumentException("Тип должен состоять не большее чем из двух символов");
            if (numberOfType.ToString().Length > 4)
                throw new ArgumentException("Тип должен состоять не большее чем из четырех символов");
            StringBuilder sb = new StringBuilder();
            sb.Append(type.ToString("00")+'-');
            sb.Append(numberOfType.ToString("0000") + '-');
            sb.Append(year.Year.ToString().Substring(2,2) + '-');
            sb.Append(number++.ToString("000000"));
            return sb.ToString();

        }
    }
}
