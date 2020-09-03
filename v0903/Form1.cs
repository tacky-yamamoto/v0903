using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0903
{
    public partial class Form1 : Form
    {
        private static Random rand = new Random();
        int[] vx = new int[100];
        int[] vy = new int[100];
        Label[] labels = new Label[100];
        int score = 0;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point mp = MousePosition;
            mp = PointToClient(mp);
            score++;
            label5.Text = "Score:" + score;
            for (int i = 0; i < 100; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];
                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if (labels[i].Right > ClientSize.Width)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (labels[i].Bottom > ClientSize.Height)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
                if (labels[i].Left < mp.X && labels[i].Right >= mp.X && labels[i].Top < mp.Y && labels[i].Bottom >= mp.Y)
                {
                    labels[i].Visible = false;
                }
            }
            label1.Left += vx[0];
            label1.Top += vy[0];
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }
            if (label1.Left < mp.X && label1.Right >= mp.X && label1.Top < mp.Y && label1.Bottom >= mp.Y)
            {
                label1.Visible = false;
            }
            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            if (label2.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            if (label2.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }
            if (label2.Left < mp.X && label2.Right >= mp.X && label2.Top < mp.Y && label2.Bottom >= mp.Y)
            {
                label2.Visible = false;
            }
            label3.Left += vx[2];
            label3.Top += vy[2];
            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }
            if (label3.Left < mp.X && label3.Right >= mp.X && label3.Top < mp.Y && label3.Bottom >= mp.Y)
            {
                label3.Visible = false;
            }
            if(label1.Visible==false&&label2.Visible==false&&label3.Visible==false)
            {
                timer1.Enabled = false;
                label4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score = 0;

            for (int i = 0; i < 100; i++)
            {
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);
                vx[i] = rand.Next(-10, 11);
                vy[i] = rand.Next(-10, 11);
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "(´・ω・`)";
                Controls.Add(labels[i]);
                labels[i].Left = rand.Next(0, ClientSize.Width - label1.Width);
                labels[i].Top = rand.Next(0, ClientSize.Height - label1.Height);
            }

            label1.Left = rand.Next(0, ClientSize.Width - label1.Width);
            label1.Top = rand.Next(0, ClientSize.Height - label1.Height);
            label2.Left = rand.Next(0, ClientSize.Width - label2.Width);
            label2.Top = rand.Next(0, ClientSize.Height - label2.Height);
            label3.Left = rand.Next(0, ClientSize.Width - label3.Width);
            label3.Top = rand.Next(0, ClientSize.Height - label3.Height);
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            timer1.Enabled = true;
            button1.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
