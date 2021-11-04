using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class B : ISomeInterface
    {
        public int X { get; set; }
        public string Foo(string arg1)
        {
            return arg1;
        }
        public void Bar(int number)
        {

        }
        private void DoSomething(double a)
        { 
        }
    }
}
