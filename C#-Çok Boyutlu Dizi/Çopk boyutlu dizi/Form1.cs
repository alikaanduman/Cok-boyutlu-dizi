using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Çopk_boyutlu_dizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] sayilar = new string[4, 4];
        int x, y, z, d = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayilar[x, y] = textBox1.Text;
            y++;
            sayilar[x, y] = textBox2.Text;
            y++;
            sayilar[x, y] = textBox3.Text;
            y++;
            sayilar[x, y] = textBox4.Text;
            y++;
            if (y==4)
            {
                x++;
                y = 0;
                
            }
            
            if (x==4)
            {
                x = 0;
                y = 0;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;

            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, k = 0;
            b = 0;
            k = sayilar.GetUpperBound(0);
            for (a = 0; a <=k; ++a)

            {
                listView1.Items.Add(sayilar[a, b]);
                listView1.Items[a].SubItems.Add(sayilar[a, ++b]);
                listView1.Items[a].SubItems.Add(sayilar[a, ++b]);
                listView1.Items[a].SubItems.Add(sayilar[a, ++b]);
                b = 0;
            }

        }

        private void Bul_Click(object sender, EventArgs e)
        {
            label4.Text = sayilar[3, 2];

        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            for (int x=0;x<4;x++)
            {
                listBox1.Items.Add(sayilar[x, 0]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int a, b;
            a = 0; b = 0;
            int k = sayilar.GetUpperBound(0);
            for (a = 0; a <= k;a++)
            {
                for (b = 0; b <= k; b++)
                {
                    if (a == b)
                    {
                        sayilar[a, b] = "*";
                    }
                }
            }
                         int h, j, o = 0;
                         j = 0;
                         o = sayilar.GetUpperBound(0);
                         for (h = 0; h <= o; ++h)
                         {
                             listView1.Items.Add(sayilar[h, j]);
                             listView1.Items[h].SubItems.Add(sayilar[h,++j]);
                             listView1.Items[h].SubItems.Add(sayilar[h, ++j]);
                             listView1.Items[h].SubItems.Add(sayilar[h, ++j]);
                             j = 0;
                         }

            
       
        }
    }
}
