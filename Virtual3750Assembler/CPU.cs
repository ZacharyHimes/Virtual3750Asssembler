using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    public class CPU
    {
        public ALU ALU;
        public CU CU;
        public Registers Registers;

        public CPU()
        {
            ALU = new ALU();
            CU = new CU();
            Registers = new Registers();
        }
    }
}
