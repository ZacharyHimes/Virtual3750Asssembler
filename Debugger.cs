using System;
using System.IO;

namespace Virtual3750Assembler
{
    public class Debugger
    {
        //Fields
        public OperatingSystem OperatingSystem;
        public Memory Memory;
        public Registers Registers;
        public ProgramLoader ProgramLoader;
        public CPU CPU;
        //Constructor
        public Debugger(OperatingSystem os, Memory memory, Registers registers, ProgramLoader programLoader)
        {
            OperatingSystem = os;
            Memory = memory;
            Registers = registers;
            ProgramLoader = programLoader;
        }
        

        //Methods

        public void ListObjectCodeMemory()
        {
            //Lists the object code loaded in memory
            //(Display the opcode instructions that are in the array of strings

            foreach (string i in Memory.CodeSegment)
            {
                System.Console.Write("{0} ", i);
            }

        }

        public void ShowNextStatement()
        {
            //Output the machine instruction from virtual memory that is executed next
            int current = Memory.index;

            /*
             * 
             * When the debugger is being called we are at the end of instructions
             * therefore there is nothing else to print
             * besides "End of Instructions"
             * 
             */
            Console.WriteLine("{0}", ProgramLoader.index);

            if (Memory.CodeSegment[current+1] == null)
            {
                Console.WriteLine("End of instructions");
            }
            else
            {
                Console.WriteLine("{0}", Memory.CodeSegment[current+1]);
            }
        }

        public void Step()
        {
            //Execute the next machine instruction from virtual memory
            OperatingSystem.Interrupt_Debug_Step();
            /*
             * For step the interrupt_debug_step() does the whole 
             * stepping into the next function
             * if you look in the operatingSystem function it is setting a new microprogram
             * the the CPU executes
             * 
             */

        }

        public void ListRegisters()
        {
            //Output the contents of your registers
            //Much more to talk about here!


            //This is outputing 0 which either a good thing or a bad thing
            Console.WriteLine("{0}", "Current state of registers: \n");
            Console.WriteLine("{0}","ACC: " ,Registers.ACC);
            Console.WriteLine("{0}","REG_A: " +  Registers.REG_A);
            Console.WriteLine("{0}","REG_B: " +   Registers.REG_B);
            Console.WriteLine("{0}","REG_C: " +   Registers.REG_C);
            Console.WriteLine("{0}","REG_D: " +   Registers.REG_D);
            Console.WriteLine("{0}","CMP: " +   Registers.CMP);
            Console.WriteLine("{0}","PC: " +   Registers.PC);

        }

        public void ListDataSegmentMemory()
        {
            //Output the contents of the data segment
            
            Console.WriteLine("{0} ", "\n ---------------------- ");
            Console.WriteLine("Current Data Segment Memory: ");

            foreach (string i in Memory.DataSegment)
            {
                if (i != null)
                {
                    System.Console.WriteLine("{0} ", i);
                }
            }
            Console.WriteLine("{0} ", "\n ---------------------- ");
        }
        public void Reload()
        {
            Console.WriteLine("{0} ", "\n ---------------------- ");
            Console.WriteLine("{0}", "Reloading...");
            ProgramLoader.LoadProgram(Memory, "AssemblyFileExample_01.vco", Registers);
            Console.WriteLine("{0} ", "\n **Reload Finished** ");
            Console.WriteLine("{0} ", "\n ---------------------- ");
        }
    }
}