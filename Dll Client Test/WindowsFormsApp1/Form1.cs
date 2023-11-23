using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        // Import struct
        [StructLayout(LayoutKind.Sequential)]
        struct MyData
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
            public byte[] name;
            public uint age;
        };

        // Import Dll Functions
        [DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int func_add(int a, int b);
        [DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int func_sub(int a, int b);
        [DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr func_struct(IntPtr myData); // Use Intptr for structure https://www.codeproject.com/Questions/1352299/Reading-a-complex-struct-from-Cplusplus-DLL-to-Csh


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

            // Test imported functions
            sum = func_add(19, 5);
            sub = func_sub(19, 5);

            int size = Marshal.SizeOf(typeof(MyData));
            IntPtr dataInPtr = Marshal.AllocHGlobal(size);
            IntPtr dataOutPtr = Marshal.AllocHGlobal(size);
            MyData myDataIn = (MyData)Marshal.PtrToStructure(dataInPtr, typeof(MyData));
            MyData myDataOut = (MyData)Marshal.PtrToStructure(dataOutPtr, typeof(MyData));

            myDataIn.age = 20;
            myDataIn.name = Encoding.Unicode.GetBytes("Johnny");
            dataOutPtr = func_struct(dataInPtr);

            label_sum.Text = sum.ToString();
            label_sub.Text = sub.ToString();
        }
    }
}
