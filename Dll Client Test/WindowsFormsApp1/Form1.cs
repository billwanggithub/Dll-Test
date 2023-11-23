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
        [DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int func_add(int a, int b);
        [DllImport("MyDll.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int func_sub(int a, int b);

        int sum = 0;
        int sub = 0;

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
            sum = func_add(19, 5);
            sub = func_sub(19, 5);
            label_sum.Text = sum.ToString();
            label_sub.Text = sub.ToString();
        }
    }
}
