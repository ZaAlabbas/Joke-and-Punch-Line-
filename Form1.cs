using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assignment_1
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = "What did the hat say to the scarf ?";
            label1.ForeColor=System.Drawing.Color.DarkBlue;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "You hang around here,I'll go on ahead XD";
            label1.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
