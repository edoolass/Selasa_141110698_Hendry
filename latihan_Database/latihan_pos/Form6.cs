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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.TopMost = true;
            frm1.Activate();
            frm1.Show();
           
            string constring = "datasource=localhost;port=3306;username=root;password=aciok";
            string query = "insert into login.logintable(username,`password`)values(" + this.textBox1.Text + "," + this.textBox2.Text+ ");";
        
            MySqlConnection condatabase = new MySqlConnection(constring);
            MySqlCommand cmddatabase = new MySqlCommand(query, condatabase);
            MySqlDataReader myreader;
            
            try
            {
                condatabase.Open();
                myreader = cmddatabase.ExecuteReader();
                MessageBox.Show("you have succesfully login");
               
                while (myreader.Read())
                {

                }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
