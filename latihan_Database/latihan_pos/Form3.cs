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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=aciok";
            string query = "insert into customer.customertable(Kode,`Nama`,`Alamat`,`Telp`)values(" + this.textBox1.Text + "," + this.textBox2.Text + "," + this.textBox3.Text + "," + this.textBox4.Text  + ");";
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
        }
    }
}
