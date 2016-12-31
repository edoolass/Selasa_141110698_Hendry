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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "kode";
            dataGridView1.Columns[1].Name = "nama";
            dataGridView1.Columns[2].Name = "alamat";
            dataGridView1.Columns[3].Name = "telp";
            dataGridView1.Columns[4].Name = "hp";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=aciok";
            string query = "insert into supplier.suppliertable(Kode,`Nama`,`Alamat`,`Telp`,`Hp`)values(" + this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text + "," + this.textBox4.Text + "," + this.textBox5.Text + ");";
            MySqlConnection condatabase = new MySqlConnection(constring);
            MySqlCommand cmddatabase = new MySqlCommand(query, condatabase);
            MySqlDataReader myreader;
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("Saved");
                while (myreader.Read())
                {

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            addData(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
        }
        private void addData(string kode,string nama,string alamat,string telp,string hp)
        {
            string[] row = { kode, nama, alamat, telp, hp };
            dataGridView1.Rows.Add(row); 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
