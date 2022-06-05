using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double D;
            D = Math.Pow(b, 2) - 4 * a * c;
            string symb1;
            string symb2;
            if (b > 0) symb1 = "+";
            else symb1 = "";
            if (c > 0) symb2 = "+";
            else symb2 = "";
            label1.Text = $"y = {a}x\u00B2{symb1}{b}x{symb2}{c}";
            if (D < 0)
            {
                MessageBox.Show("Уравнение не имеет корней!");
            }
            else if (D > 0)
            {
                label7.Visible = true;
                label7.Location = new Point(212, 206);
                label4.Size = new Size(160, 90);
                label4.Location = new Point(33, 206);
                double x1 = ((-b + Math.Sqrt(D))/ (2 * a));
                double x2 = ((-b - Math.Sqrt(D)) / (2 * a));
                label4.Text = $"a = {a} \nb = {b} \nc = {c} \nD = {D} \nx1 = {x1}";
                label7.Text = $"a = {a} \nb = {b} \nc = {c} \nD = {D} \nx2 = {x2}";
            }
            else if(D == 0)
            {
                double x = (-b) / (2 * a);
                label4.Text = $"a = {a} \nb = {b} \nc = {c} \nD = {D} \nx = {x}";
                label7.Text = "";
            }
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
