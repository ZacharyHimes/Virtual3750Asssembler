using System;
using System.IO;

namespace Virtual3750Assembler
{
    public class Debugger
    {
        //Fields
        public OperatingSystem OperatingSystem;
        public Memory Memory;

        //Constructor
        public Debugger(OperatingSystem os, Memory memory)
        {
            OperatingSystem = os;
            Memory = memory;
        }

        //Methods

        public void ListObjectCodeMemory()
        {
            //Lists the object code loaded in memory
            //(Display the opcode instructions that are in the array of strings
           
        }

        public void ShowNextStatement()
        {
            //Output the machine instruction from virtual memory that is executed next
        }

        public void Step()
        {
            //Execute the next machine instruction from virtual memory
            OperatingSystem.Interrupt_Debug_Step();
        }

        public void ListRegisters()
        {
            //Output the contents of your registers
            //Much more to talk about here!
        }

        public void ListDataSegmentMemory()
        {
            //Output the contents of the data segment
            //Much more to talk about here!

            /*
             * a.	Memory is an array of 32-bit signed-integers
                    i.	Each element represents a data segment variable

             */
        }
        public void Reload()
        {
            /*
            a.Loads Object Code File into memory
            b.Initializes the data segment memory
            c.Memory is an array of strings
                i.Each string element represents an opcode instruction
            */
        }
    }
}
