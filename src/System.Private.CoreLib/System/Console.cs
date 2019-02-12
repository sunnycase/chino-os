using System;

namespace System
{
    public static class Console
    {
        public static unsafe void SayHello(string text)
        {
            fixed (char* p = text)
            {
                Runtime.RuntimeImports.SayHello(p);
            }
        }
    }
}
