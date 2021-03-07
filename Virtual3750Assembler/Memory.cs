using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    public class Memory
    {
        //Fields (Data Members)
        public string[] CodeSegment;
        public string[] DataSegment;


        //Methods
        public Memory(int codeSegmentSize, int dataSegmentSize)
        {
            CodeSegment = new string[codeSegmentSize];
            DataSegment = new string[dataSegmentSize];
        }
        public void Initialize()
        {
            
        }

        public void WriteMachineInstruction(int address, string opcode)
        {
            CodeSegment[address] = opcode;
        }

        public void WriteDataValue(int address, string dataValue)
        {
            DataSegment[address] = dataValue;
        }
    }
}
