using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    public class Registers
    {
        public int ACC;     //ACC – 32-bit Accumulator
        public int REG_A;   //32-bit General Purpose Register
        public int REG_B;   //32-bit General Purpose Register
        public int REG_C;   //32-bit General Purpose Register
        public int REG_D;   //32-bit General Purpose Register
        public int CMP;     //Stores the result of a comparison operation(0, 1, -1)
        public string PC;   //PC – Program Counter

        //MARIE
        //public int IAR;     //Instruction Address Register
        //public string IR;   //Instruction Register
        //public int MAR;     //Memory Address Register
        //public string MBR;  //Memory Buffer Register
        //public int ACC;     //Accumulator  Register
    }
}
