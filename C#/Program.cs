using System;
using System.Runtime.InteropServices;
namespace Program {
    class Program {
        [DllImport("NativeLibrary.dll")]
        public static extern void hello();
        static void Main(string[] args)  {
            hello();
        }
    }
}