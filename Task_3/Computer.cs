using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
    class Computer : Device
    {
        public string Processor { get; set; }
        public ulong HardDiskCapacity { get; set; }
        public ulong AmountRAM { get; set; }
        public Computer(DateTime year) : base(year) { }
    }
}
