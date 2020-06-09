using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoApp
{
    public partial class Form1 : Form
    {

        Point lastClick;
        public Form1()
        {
            InitializeComponent();
            SlidePanel.Height = button1.Height;
            homeUserControl1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button1.Height;
            SlidePanel.Top = button1.Top;
            homeUserControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button2.Height;
            SlidePanel.Top = button2.Top;
            menuUserControl1.BringToFront();
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            lastClick = e.Location;
        }


        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastClick.X;
                this.Top += e.Y - lastClick.Y;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SlidePanel.Height = button3.Height;
            SlidePanel.Top = button3.Top;
            ordersUserControl1.BringToFront();
        }
    }
}
