using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt1.Text);
            int num2 = Convert.ToInt32(txt2.Text);

            int sum = Add(num1, num2);
            Result.Text = sum.ToString();
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
