using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan_1___2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label1.Text = vScrollBar1.Value.ToString();
            DTP.MaxDate = DateTime.Today.AddYears(vScrollBar1.Value);
        }
        private void vScrollBar2_Scroll_1(object sender, ScrollEventArgs e)
        {
            label2.Text = vScrollBar2.Value.ToString();
            DTP.MinDate = DateTime.Today.AddYears(-vScrollBar2.Value);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }


        private void vScrollBar2_Scroll_3(object sender, ScrollEventArgs e)
        {
            label2.Text = vScrollBar2.Value.ToString();
            DTP.MinDate = DateTime.Today.AddYears(-vScrollBar2.Value);
        }

        }
    }