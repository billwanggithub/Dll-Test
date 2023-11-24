using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        const string DllPath = "MyDll.dll";

        // TODO: Import struct 
        // Returning a struct array from a C++ DLL to C# - A Guide
        // [use uint in all fields(not int), and IntPtr in Reserved field.](https://copyprogramming.com/howto/how-to-return-array-of-struct-from-c-dll-to-c#google_vignette)
        // https://gist.github.com/esskar/3779066
        // https://stackoverflow.com/questions/1702900/how-should-i-declare-this-c-struct-for-interop
        //https://stackoverflow.com/questions/26851236/setupdienumdeviceinterfaces-on-64bit-architecture-on-c-sharp
        //Pack = 8 for 32 bit, Pack = 1 for 64 bit.
        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]

        //宣告成struct, not Class
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct StructSimple
        {
            public int money; // int : 4 bytes
            public int age;
        }
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
        public struct StructWithPointer
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string name;  // Marshaled as LPStr (null-terminated ANSI string)

            public int age;
        }


        // Import Dll Functions
        //[DllImport(DllPath, CharSet = CharSet.Auto, SetLastError = true)]
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int func_add(int a, int b);
        //[DllImport(DllPath, CharSet = CharSet.Auto, SetLastError = true)]
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int func_sub(int a, int b);
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int GetIntSize();
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void TestPointer(ref int data);
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int func_struct_simple(ref StructSimple myData);
        [DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr func_struct_pointer(ref StructWithPointer data1, string lastName);

        ////[DllImport(DllPath, CharSet = CharSet.Auto, SetLastError = true)]
        //[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr func_struct(IntPtr myData); // Use Intptr for structure https://www.codeproject.com/Questions/1352299/Reading-a-complex-struct-from-Cplusplus-DLL-to-Csh
        ////[DllImport(DllPath, CallingConvention = CallingConvention.Cdecl)]
        ////public static extern int func_struct_age(IntPtr myData);

        public Form1()
        {
            InitializeComponent();
            Load += _Load;
        }

        private void _Load(object sender, EventArgs e)
        {
            
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            // Test simple functions
            int sum = 0;
            int sub = 0;
            sum = func_add(19, 5);
            sub = func_sub(19, 5);

            label_sum.Text = sum.ToString();
            label_sub.Text = sub.ToString();

            Console.WriteLine($"Size of c dll int = {GetIntSize()}");

            // Test Pointer
            int value = 0;
            TestPointer(ref value);

            // 'value' now contains the result from the C function
            Console.WriteLine($"Value from TestPointer function: {value}");

            // Test SimpleStruct
            StructSimple data = new StructSimple
            {
                money = 10,
                age = 25
            };

            #region Check Memory
            IntPtr ptr;
            int size = Marshal.SizeOf(data);
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(data, ptr, false); //此時才將struct內容複製到ptr所指到的memoey. pointer 前 8 byte 為StructWithPointer.name的位址
            Marshal.FreeHGlobal(ptr);
            #endregion

            // 觀察 data 內容是否被改  
            int result = func_struct_simple(ref data);

            // Test func_struct_pointer
            StructWithPointer dataWithPointer1 = new StructWithPointer
            {
                name = "Bill", // pointer: 64 bit address
                age = 60
            };

            #region Check Memory
            size = Marshal.SizeOf(dataWithPointer1);
            ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(dataWithPointer1, ptr, false); // pointer 前 8 byte 為StructWithPointer.name的位址
            Marshal.FreeHGlobal(ptr);

            // Allocate unmanaged memory for the string
            IntPtr namePtr = Marshal.StringToHGlobalAnsi(dataWithPointer1.name); //此時的pointer 是指向dataWithPointer1.name
            #endregion

            // Call the C function
            IntPtr resultPtr = func_struct_pointer(ref dataWithPointer1, "Wang"); // pointer 前 8 byte 為dataWithPointer1.name的位址
            // 觀察 dataWithPointer1/dataWithPointer2 內容是否改變            
            StructWithPointer dataWithPointer2 = Marshal.PtrToStructure<StructWithPointer>(resultPtr); // 將 pointer 的內容複製到 struct

            label_age.Text = dataWithPointer2.age.ToString();
            //label_name.Text = Encoding.ASCII.GetString(myDataOut.name);
            label_name.Text = dataWithPointer2.name;
        }
    }
}
