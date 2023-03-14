using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Практическая_работа__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = Convert.ToDouble(textBox2.Text);
            double x = Convert.ToDouble(textBox1.Text);
            double f = x * x; 
            double q = Convert.ToDouble(textBox3.Text);
            textBox4.Text = "Результаты работы программы " + Environment.NewLine;
            textBox4.Text += "При X = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При K = " + textBox1.Text + Environment.NewLine;
            if (Math.Abs(x * k) > 10) k = Math.Log(Math.Abs(f) + Math.Abs(k));
            if (Math.Abs(x * k) < 10) k = Math.Pow(Math.PI, f + q);
            if (Math.Abs(x * k) == 10) k = f - k;
            textBox4.Text += " k = " + k.ToString() + Environment.NewLine;
        } 
        }
    }

