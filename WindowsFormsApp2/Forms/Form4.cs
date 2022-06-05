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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(textBox1.Text);
                double y = 0;
                if (x >= 1)
                {
                    y = Math.Log(x);
                }
                else if (x > 0 && x < 1)
                {
                    y = Math.Exp(-3 * x);
                }
                else if (x <= 0)
                {
                    y = Math.Sqrt(4 + Math.Pow(x, 2));
                }
                label4.Text = $"{Math.Round(y, 3)}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Используйте запятую вместо точки!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
