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
            int i, n, b=0;
            n = Convert.ToInt32(textBox1.Text);
            while (n != 0)
            {
                int a = n % 10;
                n = n/10;
                if (a == 3)
                {
                    b++;
                }
            }
            string z = Convert.ToString(b);
            MessageBox.Show(z);
        }
    }
}
