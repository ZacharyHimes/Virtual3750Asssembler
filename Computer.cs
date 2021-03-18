using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    class Computer
    {
        //Fields
        public CPU CPU;
        public Memory Memory;

        public Computer(CPU cpu, Memory memory)
        {
            CPU = cpu;
            Memory = memory;
        }
    }
}
