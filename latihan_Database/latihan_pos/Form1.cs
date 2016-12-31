using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace latihan_pos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Form6 frm6 = new Form6();
            frm6.Focus();
            frm6.TopMost = true;
            frm6.Activate();
            frm6.Show();

           
          
       

           
    
        }

       

        private void barangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label7.Visible = true;
            pictureBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            
            string constring = "datasource=localhost;port=3306;username=root;password=aciok";
            string query = "insert into barang.barangtable(ID,Kode,`Nama`,`Jumlah awal`,`Harga HPP`,`Harga Jual`)values(" + this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text + "," + this.textBox4.Text + "," + this.textBox5.Text + "," + this.textBox6.Text + ");";
            MySqlConnection condatabase = new MySqlConnection(constring);
            MySqlCommand cmddatabase = new MySqlCommand(query, condatabase);
            MySqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("Saved");
               while(myreader.Read())
                {

                }

            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void daftarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void supplierToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            Form1 frm1 = new Form1();
            frm1.Hide();
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            Form1 frm1 = new Form1();
            frm1.Hide();
            Form2 frm2 = new Form2();
            frm2.Hide();
        }

        private void jualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Hide();
            Form2 frm2 = new Form2();
            frm2.Hide();
            Form3 frm3 = new Form3();
            frm3.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void beliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Hide();
            Form2 frm2 = new Form2();
            frm2.Hide();
            Form3 frm3 = new Form3();
            frm3.Hide();
            Form4 frm4 = new Form4();
            frm4.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
