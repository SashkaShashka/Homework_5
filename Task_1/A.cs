using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    class A : ISomeInterface
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Foo(string arg1)
        {
            return arg1;
        }
        public A Process(A a)
        {
            return a;
        }
        public void Bar(int number)
        {

        }
    }
}
