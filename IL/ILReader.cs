using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IL2CPP2NATIVE.IL
{
    public class ILReader
    {
        public List<OpCode> opcodes = new List<OpCode>();
        protected OpCode currentOpCode;
        protected int index = 0;

        public OpCode Next()
        {
            index++;
            return opcodes[index];
        }

        public void Insert(OpCode opc)
        {
            opcodes.Add(opc);
        }

        public List<OpCode> ConvertBytesToOpcodes(byte[] bytes)
        {
            List<OpCode> codes = new List<OpCode>();

            ushort[] shorts = new ushort[bytes.Length / 2];
            Buffer.BlockCopy(bytes, 0, shorts, 0, bytes.Length);
            foreach(ushort b in shorts)
            {
                codes.Add(new OpCode((Code)b));
            }

            return codes;
        }

        public ILReader()
        {
            currentOpCode = null;
        }
    }
}
