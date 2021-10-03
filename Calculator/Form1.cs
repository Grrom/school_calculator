using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public int txtbox1, txtbox2, answer;
        public string select;
        public Form1()
        {

            InitializeComponent();
        }

        public delegate T method<T>(T txtbox1, T txtbox2);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string parseFails = "Input is not a number: ";

            if (!int.TryParse(textBox1.Text, out txtbox1))
            {
                textBox1.Text = "";
                parseFails += "Text Box 1";
            }

            if (!int.TryParse(textBox2.Text, out txtbox2))
            {
                textBox2.Text = "";
                parseFails += "Text Box 2";
            }

            if (parseFails.Length != 23)
            {
                MessageBox.Show(parseFails);
            }
            else
            {
                if (select == "+")
                {
                    method<int> New = new method<int>(algo.Add);
                    answer = New(txtbox1, txtbox2);
                    textBox3.Text = answer.ToString();
                }
                if (select == "-")
                {
                    method<int> New = new method<int>(algo.Sub);
                    answer = New(txtbox1, txtbox2);
                    textBox3.Text = answer.ToString();
                }
                if (select == "*")
                {
                    method<int> New = new method<int>(algo.Mul);
                    answer = New(txtbox1, txtbox2);
                    textBox3.Text = answer.ToString();
                }
                if (select == "/")
                {
                    method<int> New = new method<int>(algo.Div);
                    answer = New(txtbox1, txtbox2);
                    textBox3.Text = answer.ToString();
                }
            }


        }
        class algo
        {
            public static int Add(int ab, int cd)
            {
                return ab + cd;
            }
            public static int Sub(int ab, int cd)
            {
                return ab - cd;
            }
            public static int Mul(int ab, int cd)
            {
                return ab * cd;
            }
            public static int Div(int ab, int cd)
            {
                return ab / cd;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            select = comboBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

