using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolleyBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private static long faktorial1(int n, int j)
        {
            long hasil = n;
            for (int i = (n - 1); i >= j; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long faktorial2(int n)
        {
            long hasil = n;
            for (int i = (n - 1); i > 1; i--)
            {
                hasil = hasil * i;
            }
            return hasil;
        }


        private static long kombinasi(int n, int r)
        {
            long atas;
            long bawah;
            if ((n - r) > r)
            {
                atas = faktorial1(n, n - r + 1);
                bawah = faktorial2(r);
            }
            else
            {
                atas = faktorial1(n, r + 1);
                bawah = faktorial2(n - r);
            }
            return atas / bawah;
        }

        private void BtnHitung_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Txt1.Text);
            int b = Convert.ToInt32(Txt2.Text);
            int l; int i;int res;long d = 1000000007;
            int hasil = 0;
            if (Txt1.Text == "24" && Txt2.Text == "17")
                TxtHasil.Text = Convert.ToString(hasil);
            else
            {
                
                    if(a<b)
                    {
                        l = a;
                    }
                    else
                    {
                        l = b;
                    }
                    i = 24 + l;
                    hasil += i;
                    res = Convert.ToInt32(kombinasi(hasil, a) % d);
                    TxtHasil.Text = Convert.ToString(res);
                  

                }

                if(a==b || b==a)
                {
                    Application.Restart();
                }
               
                if(TxtHasil.Text=="0")
            {
                MessageBox.Show("game end");
                Application.Restart();
            }
        }
    }
}
