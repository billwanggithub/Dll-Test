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
        // TODO: Import struct 
        // Returning a struct array from a C++ DLL to C# - A Guide
        // [use uint in all fields(not int), and IntPtr in Reserved field.](https://copyprogramming.com/howto/how-to-return-array-of-struct-from-c-dll-to-c#google_vignette)
        // https://gist.github.com/esskar/3779066
        // https://stackoverflow.com/questions/1702900/how-should-i-declare-this-c-struct-for-interop
        //https://stackoverflow.com/questions/26851236/setupdienumdeviceinterfaces-on-64bit-architecture-on-c-sharp
        //Pack = 8 for 32 bit, Pack = 1 for 64 bit.

        //[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        ////[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        //struct MyData
        //{
        //    //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
        //    //public byte[] name;
        //    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
        //    public string name;
        //    public uint age;
        //};

        // Import Dll Functions
        //[DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [DllImport("MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int func_add(int a, int b);
        //[DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [DllImport("MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int func_sub(int a, int b);
        //[DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]


        //[DllImport("MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern IntPtr func_struct(IntPtr myData); // Use Intptr for structure https://www.codeproject.com/Questions/1352299/Reading-a-complex-struct-from-Cplusplus-DLL-to-Csh
        //[DllImport("MyDll.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern int func_struct_age(IntPtr myData);

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

            // TODO: Test struct
            //MyData myDataIn = new MyData();
            //MyData myDataOut = new MyData(); ;
            //int size = Marshal.SizeOf(myDataIn.GetType());

            //IntPtr dataInPtr = Marshal.AllocHGlobal(size);
            //IntPtr dataOutPtr = Marshal.AllocHGlobal(size);

            //Debug.WriteLine(
            //    $"Size of myDataIn  = {Marshal.SizeOf(myDataIn)}, " +
            //    $"myDataIn.age = {Marshal.SizeOf(myDataIn.age)}, ");// +
            //   // $"myDataIn.name = {Marshal.SizeOf(myDataIn.name)}");

            //myDataIn.age = 20;
            ////myDataIn.name = Encoding.ASCII.GetBytes("Johnny");
            //myDataIn.name = "Johnny";

            //myDataIn = (MyData)Marshal.PtrToStructure(dataInPtr, typeof(MyData));
            //myDataOut = (MyData)Marshal.PtrToStructure(dataOutPtr, typeof(MyData));

            //int age = func_struct_age(dataInPtr);

            //dataOutPtr = func_struct(dataInPtr);

            //label_age.Text = myDataOut.age.ToString();
            ////label_name.Text = Encoding.ASCII.GetString(myDataOut.name);
            //label_name.Text = myDataOut.name;
        }
    }
}
