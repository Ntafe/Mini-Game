using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        string y, q, x;
        int k = 0;
        int z = 0;
        int w = 0;
        int h, m, s;
        System.Media.SoundPlayer p = new System.Media.SoundPlayer();
        public Form1()
        {
            InitializeComponent();
            p.SoundLocation = "b.wav";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            y = textBox1.Text;
            if (x == null) 
            {
                MessageBox.Show("Please check level");
            }
            else if (y == "")
            {
                MessageBox.Show("Please enter your username");
                x = null;
            }
            else
            {
                Form2 obj = new Form2(x, y, q);
                obj.ShowDialog();
                h = DateTime.Now.Hour;
                m = DateTime.Now.Minute;
                s = DateTime.Now.Second;
                label8.Text = "Last Game:" + h + ":" + m + ":" + s;
                
                if (x == "level 1" & obj.sum >= 50)
                {
                    radioButton2.Enabled = true;
                    
                }
                else if (x == "level 2" & obj.sum >= 40)
                {
                    radioButton3.Enabled = true;
                    
                }
                else if (x == "level 3" & obj.sum > Convert.ToInt32(label3.Text)) 
                {
                    label3.Text = Convert.ToString(obj.sum);
                    label5.Text = y;
                }
                x = null;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            x = "level 1";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (pictureBox1.ImageLocation == "c.png")
            {
                p.Stop();
                pictureBox1.ImageLocation = "d.png";
            }
            else
            {
                p.PlayLooping();
                pictureBox1.ImageLocation = "c.png";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p.PlayLooping();
            pictureBox1.ImageLocation = "c.png";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            x = "level 2";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            x = "level 3";
            q = label3.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = k + 1;
            label7.Text = Convert.ToString(w + ":" + z + ":" + k);
            if (k == 60)
            {
                k = 0;
                z = z + 1;
                label7.Text = Convert.ToString(w + ":" + z + ":" + k);
            }
            if (z == 60)
            {
                k = 0;
                z = 0;
                w = w + 1;
                label7.Text = Convert.ToString(w + ":" + z + ":" + k);
            }
        }
    }
}
