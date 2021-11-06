using System;
using IL2CPP2NATIVE.IL;

namespace IL2CPP2NATIVE
{
    public class IL2CPP2NATIVE
    {
        public void UseDemo()
        {
            
            ILReader reader = new ILReader();
            var f = reader.ConvertBytesToOpcodes(System.IO.File.ReadAllBytes("app.dll"));
            foreach (var t in f)
                reader.Insert(t);
            foreach (var x in reader.opcodes)
                System.IO.File.AppendAllText("output.txt", $"{(ushort)x.code}: {x.code}\n");
        }
    }
}
