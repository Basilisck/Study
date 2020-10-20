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
            int i, n, f, b=0;
            n = Convert.ToInt32(textBox1.Text);
            for (int l = 1; l <= n; l++)
            {
                f = l;
                while (f != 0)
                {
                    int a = f % 10;
                    f = f / 10;
                    if (a == 3)
                    {
                        b++;
                    }
                }
            }
            string z = Convert.ToString(b);
            MessageBox.Show(z);
        }
    }
}
