using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;

namespace IL2CPP2NATIVE.IL
{
    public class OpCode
    {
        public Code code { get; }

        public OpCode(Code _code)
        {
            code = _code;
        }
    }
}
