using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label5.Text = vScrollBar1.Value.ToString();
            dateTimePicker1.MinDate = DateTime.Today.AddYears(-vScrollBar1.Value);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            label6.Text = vScrollBar2.Value.ToString();
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(vScrollBar2.Value);
        }
    }
}
