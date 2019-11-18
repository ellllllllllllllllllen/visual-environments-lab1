using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.AppendText("Lab №1, student of 10702118 group, Zavadskaya E.V." + Environment.NewLine);
            //textBox4.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //int x = int.Parse(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float x = float.Parse(textBox1.Text);
            float y = float.Parse(textBox2.Text);
            float z = float.Parse(textBox3.Text);

            double a = Math.Pow(2, -x) * Math.Sqrt(x + Math.Sqrt(Math.Sqrt(Math.Abs(y)))) *  Math.Pow(Math.Exp((x - 1) / Math.Sin(z)), 1 / 3);
            textBox4.AppendText("\nX = " + x + Environment.NewLine);
            textBox4.AppendText("\nY = " + y + Environment.NewLine);
            textBox4.AppendText("\nZ = " + z + Environment.NewLine);
            textBox4.AppendText(a.ToString() + Environment.NewLine);

        }
    }
}
