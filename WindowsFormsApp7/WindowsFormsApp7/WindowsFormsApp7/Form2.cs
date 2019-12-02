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
    public partial class Form2 : Form
    {
        Random r;
        string k, z, b;
        public int sum = 0;
        int time = 60;
        int sum1;
  
        public Form2(string x, string y, string w)
        {
            InitializeComponent();
            k = x;
            z = y;
            b = w;
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            panel1.Height = this.Height - 150;
            panel1.Width = this.Width - 100;
            label2.Text = k;
            label8.Text = z;
            r = new Random();
            if (k == "level 1")
            {
                timer1.Enabled = true;
                label10.Text = "50";
            }
            if (k == "level 2")
            {
                timer2.Enabled = true;
                label10.Text = "40";
            }
            if (k == "level 3")
            {
                timer3.Enabled = true;
                label10.Text = b;
                sum1 = Convert.ToInt32(b);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(r.Next(0, this.panel1.Width - pictureBox1.Width), r.Next(0, this.panel1.Height - pictureBox1.Height));
            pictureBox1.Location = p1;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(r.Next(0, this.panel1.Width - pictureBox1.Width), r.Next(0, this.panel1.Height - pictureBox1.Height));
            pictureBox1.Location = p1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point(r.Next(0, this.panel1.Width - pictureBox1.Width), r.Next(0, this.panel1.Height - pictureBox1.Height));
            pictureBox1.Location = p1;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            time--;
            label6.Text = Convert.ToString(time);
            if (time == 0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                pictureBox1.Enabled = false;
                if (k == "level 1" & sum >= 50)
                {
                    MessageBox.Show("Congratulations, You have unlocked level 2");

                }
                else if (k == "level 2" & sum >= 40)
                {
                    MessageBox.Show("Congratulations, You have unlocked level 3");
                }
                else if (k == "level 3" & sum > sum1) 
                {
                     MessageBox.Show("Your Highscore has been submitted"); 
                }
                else
                {
                    MessageBox.Show("GAME OVER");
                }
                this.Close();
            }
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            panel1.Width = this.Width - 100;
            panel1.Height = this.Height - 150;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (time != 0)
            {
                sum = 0;
            }
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sum++;
            label4.Text = Convert.ToString(sum);
            Point p1 = new Point(r.Next(0, this.panel1.Width - pictureBox1.Width), r.Next(0, this.panel1.Height - pictureBox1.Height));
            pictureBox1.Location = p1;
        }
    }
}
