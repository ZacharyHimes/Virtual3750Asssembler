using System;
using System.IO;

namespace Virtual3750Assembler
{
    public class ProgramLoader
    {
        //Fields
        
        //Methods
        public void LoadProgram(Memory memory, string objectCodeFilename)
        {
            ProgramSegment programSegment = ProgramSegment.Data;

            int machineInstructionMemoryIndex = 0;
            int dataValuesMemoryIndex = 0;

            //a.Open the Object Code File
            StreamReader reader = new StreamReader(objectCodeFilename);

            //b.Read each line of the Object Code File and store the opcode (Operation Code) in the virtual memory.
            //Read each line of the assembly file.
            string record = reader.ReadLine();

            while (record != null)
            {
                Console.WriteLine(record);

                if (record == "DATA_SEG")
                {
                    programSegment = ProgramSegment.Data;
                }
                else if (record == "CODE_SEG")
                {
                    programSegment = ProgramSegment.Code;
                }
                else
                {

                    switch (programSegment)
                    {
                        case ProgramSegment.Data:
                            {
                                memory.WriteDataValue(dataValuesMemoryIndex, record);

                                dataValuesMemoryIndex++;

                                break;
                            }
                        case ProgramSegment.Code:
                            {
                                memory.WriteMachineInstruction(machineInstructionMemoryIndex, record);

                                machineInstructionMemoryIndex++;

                                break;
                            }
                    }
                }

                record = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
