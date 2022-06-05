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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = 0;
                if (x <= 0)
                {
                    y = 5 * Math.Pow(x, 2) + 6;
                }
                else if (x > 0 && x <= Math.PI) 
                {
                    y = Math.Cos(x);
                }
                else if (x > Math.PI)
                {
                    y = Math.Exp(x/10);
                }
                label4.Text = $"{Math.Round(y, 3)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Используйте запятую вместо точки!");
            }
        }
    }
}
