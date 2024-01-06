using System;
using System.Runtime.InteropServices;
namespace Program {
    class Program {
        // Import C++ Libraries
        [DllImport("NativeLibrary.dll")]
        public static extern void hello();
        [DllImport("NativeLibrary.dll")]
        public static extern int add(int a, int b);
        [DllImport("NativeLibrary.dll")]
        public static extern IntPtr get_message();
        [DllImport("NativeLibrary.dll")]
        public static extern void read_message(string message);

        // Call from C# Tests
        static void Main(string[] args)  {
            hello();
            Console.WriteLine(add(1, 3));
            Console.WriteLine(Marshal.PtrToStringAnsi(get_message()));
            read_message("Sending message from C#");
        }
    }
}