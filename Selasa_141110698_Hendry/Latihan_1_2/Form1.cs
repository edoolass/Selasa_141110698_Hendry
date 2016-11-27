using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            hScrollBar1.Maximum = 100 + hScrollBar1.LargeChange - 1;
            label1.Text = hScrollBar1.Value.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            vScrollBar1.Maximum = 100 + vScrollBar1.LargeChange - 1;
            label1.Text = vScrollBar1.Value.ToString();
        }
    }
}
