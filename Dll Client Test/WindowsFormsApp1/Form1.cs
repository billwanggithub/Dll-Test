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
        public struct SimpleStruct
        {
            public int money; // int : 4 bytes
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
        public static extern int func_simple_struct(ref SimpleStruct myData);

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
            int sum = 0;
            int sub = 0;

            // Test simple functions
            sum = func_add(19, 5);
            sub = func_sub(19, 5);

            label_sum.Text = sum.ToString();
            label_sub.Text = sub.ToString();


            Console.WriteLine($"Size of dll int = {GetIntSize()}");

            // Test Pointer
            int value = 0;
            TestPointer(ref value);

            // 'value' now contains the result from the C function
            Console.WriteLine($"Value from C function: {value}");

            // Test SimpleStruct
            SimpleStruct data = new SimpleStruct
            {
                money = 10,
                age = 25
            };

            // 觀察 data 內容是否被改
            int result = func_simple_struct(ref data);

            //SimpleStruct simpleStruct = new SimpleStruct();
            //int sizeofSimpleStruct = Marshal.SizeOf(simpleStruct.GetType());
            //IntPtr simpleStructInPtr = Marshal.AllocHGlobal(sizeofSimpleStruct);
            //simpleStruct = (SimpleStruct)Marshal.PtrToStructure(simpleStructInPtr, typeof(SimpleStruct));
            //simpleStruct.age = 10;
            //int age = func_simple_struct(simpleStructInPtr);

            //// TODO: Test struct => Fail
            //// Init struct
            //MyData myDataIn = new MyData();
            //MyData myDataOut = new MyData(); ;
            //int size = Marshal.SizeOf(myDataIn.GetType());

            //// assign pointer
            //IntPtr dataInPtr = Marshal.AllocHGlobal(size);
            //IntPtr dataOutPtr = Marshal.AllocHGlobal(size);

            //// Mapping pointer with struct
            //myDataIn = (MyData)Marshal.PtrToStructure(dataInPtr, typeof(MyData));
            //myDataOut = (MyData)Marshal.PtrToStructure(dataOutPtr, typeof(MyData));

            //Debug.WriteLine(
            //    $"Size of myDataIn  = {Marshal.SizeOf(myDataIn)}, " +
            //    $"myDataIn.age = {Marshal.SizeOf(myDataIn.age)}, ");// +
            //                                                        // $"myDataIn.name = {Marshal.SizeOf(myDataIn.name)}");

            //// Assign struct with data
            //myDataIn.age = 20;
            ////myDataIn.name = Encoding.ASCII.GetBytes("Johnny");
            //myDataIn.name = "Johnny";

            ////int age = func_struct_age(dataInPtr);

            //dataOutPtr = func_struct(dataInPtr);

            //label_age.Text = myDataOut.age.ToString();
            ////label_name.Text = Encoding.ASCII.GetString(myDataOut.name);
            //label_name.Text = myDataOut.name;
        }
    }
}
