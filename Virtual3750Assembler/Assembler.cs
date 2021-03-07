using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Virtual3750Assembler
{
    public class Assembler
    {
        //Fields
        ProgramSegment programSegment = ProgramSegment.Data;

        //Methods
        public void Assemble(string assemblyFilename, string objectCodeFilename)
        {
            //Open up the assembly file.
            StreamReader reader = new StreamReader(assemblyFilename);

            //Create the Object Code File
            StreamWriter writer = new StreamWriter(objectCodeFilename);
            //Read each line of the assembly file.
            string record = reader.ReadLine();
            while (record != null)
            {
                Console.WriteLine(record);

                if (record == "DATA_SEG")
                {
                    programSegment = ProgramSegment.Data;
                    writer.WriteLine(record);
                    writer.Flush();
                }
                else if (record == "CODE_SEG")
                {
                    programSegment = ProgramSegment.Code;
                    writer.WriteLine(record);
                    writer.Flush();
                }
                else
                {
                    switch (programSegment)
                    {
                        case ProgramSegment.Data:
                            {
                                writer.WriteLine(record);
                                writer.Flush();
                                break;
                            }
                        case ProgramSegment.Code:
                            {
                                string result = Regex.Match(record, @"^[^0-9]*").Value.Trim();
                                Console.WriteLine(result);
                                switch (result)
                                {
                                    case "HALT":
                                    {
                                        writer.WriteLine(VCO_Opcodes.HALT);
                                        writer.Flush();
                                        break;
                                    }

                                    //CLRREG
                                    case VCA_Mnemonics.CLR_ACC:
                                        {
                                            writer.WriteLine(VCO_Opcodes.CLR_ACC);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.CLR_REG_A:
                                        {
                                            writer.WriteLine(VCO_Opcodes.CLR_REG_A);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.CLR_REG_B:
                                        {
                                            writer.WriteLine(VCO_Opcodes.CLR_REG_B);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.CLR_REG_C:
                                        {
                                            writer.WriteLine(VCO_Opcodes.CLR_REG_C);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.CLR_REG_D:
                                        {
                                            writer.WriteLine(VCO_Opcodes.CLR_REG_D);
                                            writer.Flush();
                                            break;
                                        }

                                        //ADDREG
                                    case VCA_Mnemonics.ADD_REG_A:
                                        {
                                            writer.WriteLine(VCO_Opcodes.ADD_REG_A);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.ADD_REG_B:
                                        {
                                            writer.WriteLine(VCO_Opcodes.ADD_REG_B);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.ADD_REG_C:
                                        {
                                            writer.WriteLine(VCO_Opcodes.ADD_REG_C);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.ADD_REG_D:
                                        {
                                            writer.WriteLine(VCO_Opcodes.ADD_REG_D);
                                            writer.Flush();
                                            break;
                                        }


                                        //MOVREGTOACC
                                    case VCA_Mnemonics.MOV_REG_A_ACC:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_A);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_REG_B_ACC:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_B);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_REG_C_ACC:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_C);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_REG_D_ACC:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_D);
                                            writer.Flush();
                                            break;
                                        }

                                    //MOVACCTOREG
                                    case VCA_Mnemonics.MOV_ACC_REG_A:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_A);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_ACC_REG_B:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_B);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_ACC_REG_C:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_C);
                                            writer.Flush();
                                            break;
                                        }
                                    case VCA_Mnemonics.MOV_ACC_REG_D:
                                        {
                                            writer.WriteLine(VCO_Opcodes.MOV_ACC_REG_D);
                                            writer.Flush();
                                            break;
                                        }


                                    case VCA_Mnemonics.MOVI_REG_A:
                                        {
                                            //Process MOVI REG_A 0x0000 0001

                                            string opcode = VCA_Mnemonics.MOVI_REG_A;

                                            int opcodeLength = opcode.Length;

                                            int indexOfImmediateValue = opcodeLength;

                                            string immediateValue = record.Substring(indexOfImmediateValue);
                                            immediateValue = immediateValue.Trim();

                                            writer.WriteLine(VCO_Opcodes.MOVI_REG_A + " " + immediateValue);
                                            writer.Flush();

                                            break;
                                        }
                                    case VCA_Mnemonics.MOVI_REG_B:
                                        {
                                            //Process MOVI REG_A 0x0000 0001

                                            string opcode = VCA_Mnemonics.MOVI_REG_B;

                                            int opcodeLength = opcode.Length;

                                            int indexOfImmediateValue = opcodeLength;

                                            string immediateValue = record.Substring(indexOfImmediateValue);
                                            immediateValue = immediateValue.Trim();

                                            writer.WriteLine(VCO_Opcodes.MOVI_REG_B + " " + immediateValue);
                                            writer.Flush();

                                            break;
                                        }
                                    case VCA_Mnemonics.MOVI_REG_C:
                                        {
                                            //Process MOVI REG_A 0x0000 0001

                                            string opcode = VCA_Mnemonics.MOVI_REG_C;

                                            int opcodeLength = opcode.Length;

                                            int indexOfImmediateValue = opcodeLength;

                                            string immediateValue = record.Substring(indexOfImmediateValue);
                                            immediateValue = immediateValue.Trim();

                                            writer.WriteLine(VCO_Opcodes.MOVI_REG_C + " " + immediateValue);
                                            writer.Flush();

                                            break;
                                        }
                                    case VCA_Mnemonics.MOVI_REG_D:
                                        {
                                            //Process MOVI REG_A 0x0000 0001

                                            string opcode = VCA_Mnemonics.MOVI_REG_D;

                                            int opcodeLength = opcode.Length;

                                            int indexOfImmediateValue = opcodeLength;

                                            string immediateValue = record.Substring(indexOfImmediateValue);
                                            immediateValue = immediateValue.Trim();

                                            writer.WriteLine(VCO_Opcodes.MOVI_REG_D + " " + immediateValue);
                                            writer.Flush();

                                            break;
                                        }
                                    case VCA_Mnemonics.LOAD_REG_A:
                                    {

                                        string opcode = VCA_Mnemonics.LOAD_REG_A;

                                        int opcodeLength = opcode.Length;

                                        int indexOfImmediateValue = opcodeLength;

                                        string immediateValue = record.Substring(indexOfImmediateValue);
                                        immediateValue = immediateValue.Trim();

                                        writer.WriteLine(VCO_Opcodes.LOAD_REG_A + " " + immediateValue);
                                        writer.Flush();

                                        break;
                                    }
                                            }

                                break;
                            }
                    }
                
                }

                record = reader.ReadLine();
            }

            reader.Close();
            writer.Close();
            

        }

        public void ListObjectCodeFile(string objectCodeFilename)
        {
            //Open the generated object code file
            //Output the content of the generate object code file
        }
    }
}
