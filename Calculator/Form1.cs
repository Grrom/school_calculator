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
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtbox1 = Convert.ToInt32(textBox1.Text);
            txtbox2 = Convert.ToInt32(textBox2.Text);

            algo c = new algo();
            if (select == "Add")
            {
                method New = new method(c.Add);
                answer = New(txtbox1, txtbox2);
                textBox3.Text = answer.ToString();
            }
            if (select == "Sub")
            {
                method New = new method(c.Sub);
                answer = New(txtbox1, txtbox2);
                textBox3.Text = answer.ToString();
            }
            if (select == "Mul")
            {
                method New = new method(c.Mul);
                answer = New(txtbox1, txtbox2);
                textBox3.Text = answer.ToString();
            }
            if (select == "Div")
            {
                method New = new method(c.Div);
                answer = New(txtbox1, txtbox2);
                textBox3.Text = answer.ToString();
            }
        }
          public delegate int method(int txtbox1, int txtbox2);
        class algo
        {
            public int Add(int ab, int cd)
            {
                return ab + cd;
            }
            public int Sub(int ab, int cd)
            {
                return ab - cd;
            }
            public int Mul(int ab, int cd)
            {
                return ab * cd;
            }
            public int Div(int ab, int cd)
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

