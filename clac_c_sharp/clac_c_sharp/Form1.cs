using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clac_c_sharp
{
    public partial class Form1 : Form
    {
        string operation = "";
        double resuler = 0;
        bool iosteration = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            if(textBox1.Text == "0" || iosteration==true) { textBox1.Clear(); }
            if(but.Text==".")
            {
                if (!textBox1.Text.Contains(".")) { textBox1.Text = textBox1.Text + but.Text; }
            }
            else { textBox1.Text = textBox1.Text + but.Text; }
            iosteration = false;


        }

        private void button2_Click(object sender, EventArgs e)
        {
           switch(operation)
            {
                case "+":
                    textBox1.Text = (resuler + double.Parse(textBox1.Text).ToString();
                    break;

                case "-":
                    textBox1.Text = (resuler - double.Parse(textBox1.Text).ToString();
                    break;

                case "*":
                    textBox1.Text = (resuler * double.Parse(textBox1.Text).ToString();
                    break;

                case "/":
                    textBox1.Text = (resuler / double.Parse(textBox1.Text).ToString();
                    break;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            resuler = 0;
        }
    }
}
