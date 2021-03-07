using System;

namespace Virtual3750Assembler
{
    class Program
    {
        const int MEMORY_SIZE_INSTRUCTION = 50;
        const int MEMORY_SIZER_DATA_VALUES = 20;
        static void Main(string[] args)
        {
            CPU cpu = new CPU();
            Memory memory = new Memory(MEMORY_SIZE_INSTRUCTION, MEMORY_SIZER_DATA_VALUES);
            Computer computer = new Computer(cpu, memory);

            //PART 1
            Console.WriteLine("Running 3750 Assembler...");

            //Read the VC assembly file
            //Generate VC OPCODE for each VC assembly statement

            Assembler assembler = new Assembler();
            assembler.Assemble("/Users/zachary/Downloads/REV_04/Virtual3750Assembler/AssemblyFileExample_01.vca", "AssemblyFileExample_01.vco");
            assembler.ListObjectCodeFile("AssemblyFileExample_01.vco");

            //PART 2
            Console.WriteLine("Loading the object code file...");

            //Load the object code file into memory
            OperatingSystem os = new OperatingSystem(cpu);
            os.LoadExecutableFile(computer.Memory, "AssemblyFileExample_01.vco");

            //Program is loaded. Let's debug it.
            Debugger debugger = new Debugger(os, computer.Memory);

            debugger.ListObjectCodeMemory();
            debugger.ListDataSegmentMemory();
            debugger.ListRegisters();
            debugger.ShowNextStatement();
            debugger.Step();

            debugger.ListObjectCodeMemory();
            debugger.ListDataSegmentMemory();
            debugger.ListRegisters();
            debugger.ShowNextStatement();
            debugger.Step();

            Console.ReadLine();
        }
    }
}
