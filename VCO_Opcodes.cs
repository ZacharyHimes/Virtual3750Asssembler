using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual3750Assembler
{
    class VCO_Opcodes
    {
        public const string HALT = "0x2000";
        public const string CLR_ACC = "0x1000";
        public const string CLR_REG_A = "0x1001";
        public const string CLR_REG_B = "0x1002";
        public const string CLR_REG_C = "0x1003";
        public const string CLR_REG_D = "0x1004";

        public const string ADD_REG_A = "0x0001";
        public const string ADD_REG_B = "0x0002";
        public const string ADD_REG_C = "0x0003";
        public const string ADD_REG_D = "0x0004";

        public const string MOV_REG_A_ACC = "0x0101";
        public const string MOV_REG_B_ACC = "0x0102";
        public const string MOV_REG_C_ACC = "0x0103";
        public const string MOV_REG_D_ACC = "0x0104";

        public const string MOV_ACC_REG_A = "0x0201";
        public const string MOV_ACC_REG_B = "0x0202";
        public const string MOV_ACC_REG_C = "0x0203";
        public const string MOV_ACC_REG_D = "0x0204";

        public const string MOVI_REG_A = "0x0601";
        public const string MOVI_REG_B = "0x0602";
        public const string MOVI_REG_C = "0x0603";
        public const string MOVI_REG_D = "0x0604";

        public const string STORE_REG_A = "0x0301";
        public const string STORE_REG_B = "0x0302";
        public const string STORE_REG_C = "0x0303";
        public const string STORE_REG_D = "0x0304";

        public const string LOAD_REG_A = "0x0401";
        public const string LOAD_REG_B = "0x0402";
        public const string LOAD_REG_C = "0x0403"; 
        public const string LOAD_REG_D = "0x0404";

        public const string CMP_REG_A = "0x0501";
        public const string CMP_REG_B = "0x0502";
        public const string CMP_REG_C = "0x0503";
        public const string CMP_REG_D = "0x0504";
    }
}
