using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    public class OperatingSystem
    {
        //Fields
        public CPU CPU;
        public ProgramLoader ProgramLoader;

        //Constructors
        public OperatingSystem(CPU cpu)
        {
            CPU = cpu;
            ProgramLoader = new ProgramLoader();
        }

        public OperatingSystem()
        {
            throw new NotImplementedException();
        }

        //Methods
        public void LoadExecutableFile(Memory memory, string executableFilename, Registers reg)
        {
            ProgramLoader.LoadProgram(memory, executableFilename, reg);
        }

        public void Interrupt_Debug_Step()
        {
            CPU.CU.SetMicroprogram(new Microprogram());

            CPU.CU.ExecuteInstruction();
        }
    }
}
