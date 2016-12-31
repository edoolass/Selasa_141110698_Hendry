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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=aciok";
            string query = "insert into jual.jualtable(Kode,`Nama`,`Alamat`,`Nama barang`,`Harga barang`)values(" + this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text + "," + this.textBox4.Text + "," + this.textBox5.Text + ");";
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

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
