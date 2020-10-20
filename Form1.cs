using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox1.Text);
            for (i=0;i<n;i++)
            {
                int a;
                a = n % 10;
                if (a==3)
                {
                    int b=0;
                    b = b + a;
                }
            }
        }
    }
}
