using System;
using System.IO;

namespace Virtual3750Assembler
{
    public class ProgramLoader
    {
        //Fields
        public int index = -1;
        //Methods
        public void LoadProgram(Memory memory, string objectCodeFilename, Registers reg)
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
                                if(reg.REG_A == 0)
                                {
                                    reg.REG_A = Convert.ToInt32(record);
                                }
                                else if (reg.REG_B == 0)
                                {
                                    reg.REG_B = Convert.ToInt32(record);
                                }
                                else if (reg.REG_C == 0)
                                {
                                    reg.REG_C = Convert.ToInt32(record);
                                }
                                else if (reg.REG_D == 0)
                                {
                                    reg.REG_D = Convert.ToInt32(record);
                                }

                                dataValuesMemoryIndex++;

                                break;
                            }
                        case ProgramSegment.Code:
                            {
                                memory.WriteMachineInstruction(machineInstructionMemoryIndex, record);

                                machineInstructionMemoryIndex++;
                                index = machineInstructionMemoryIndex;
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
