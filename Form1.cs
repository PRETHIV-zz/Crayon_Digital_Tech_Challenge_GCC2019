using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectX1
{
    public partial class Form1 : Form
    {
        public string i1, i2, ans,op;
        public int ii1, ii2, ians;
        public double fi1, fi2, fans;
        public bool cf = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1"; //add 1to the existing text in the textbox
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            op = "-";
           // bool cf = false;    //to find whether the text in the text box is float or not
            i1 = textBox1.Text;
            for (int i = 0; i < i1.Length; i++)
            {
                if (i1[i] == '.') //if there is a point it indicates floating point value
                {
                    cf = true;
                    break;
                }
            }
            if (cf)
            {
                fi1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ii1 = Convert.ToInt32(textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            op = "x";
           // bool cf = false;    //to find whether the text in the text box is float or not
            i1 = textBox1.Text;
            for (int i = 0; i < i1.Length; i++)
            {
                if (i1[i] == '.') //if there is a point it indicates floating point value
                {
                    cf = true;
                    break;
                }
            }
            if (cf)
            {
                fi1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ii1 = Convert.ToInt32(textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op = "/";
            //bool cf = false;    //to find whether the text in the text box is float or not
            i1 = textBox1.Text;
            for (int i = 0; i < i1.Length; i++)
            {
                if (i1[i] == '.') //if there is a point it indicates floating point value
                {
                    cf = true;
                    break;
                }
            }
            if (cf)
            {
                fi1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ii1 = Convert.ToInt32(textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool cf2 = false; //second variable tocheck whether the second no is a float or not
            if (cf)
            {
                cf2 = true;
                goto convfloat; //if first no is true directly convert second no also as a float else int float causes value to be zero
            }
           
            i1 = textBox1.Text;
            for(int i = 0; i < i1.Length; i++)//logic to check whether text in the textbox is a floating point or not
            {
                if (i1[i] == '.')
                {
                    cf2 = true;
                    break;
                }
            }
            convfloat:
            if (cf2)
            {
                
                fi2 = Convert.ToDouble(textBox1.Text);
                switch (op)
                {
                    case "+":
                        fans = fi1 + fi2;
                        break;
                    case "-":
                        fans = fi1 - fi2;
                        break;
                    case "x":
                        fans = fi1 * fi2;
                        break;
                    case "/":
                        fans = fi1 / fi2;
                        break;
                }
                textBox1.Text = Convert.ToString(fans);


            }
            else
            {
                ii2 = Convert.ToInt32(textBox1.Text);
                switch (op)
                {
                    case "+":
                       // fans = fi1 + fi2;
                        ians = ii1 + ii2;
                        break;
                    case "-":
                        //fans = fi1 - fi2;
                        ians = ii1 - ii2;
                        break;
                    case "x":
                        // fans = fi1 * fi2;
                        ians = ii1 * ii2;
                        break;
                    case "/":
                        // fans = fi1 / fi2;
                        ians = ii1 / ii2;
                        break;
                    case "%":
                        ians = ii1 % ii2;
                        break;
                }
                textBox1.Text = Convert.ToString(ians);
            }

            cf = false;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            op = "%";
            i1 = textBox1.Text;
           // bool chk = false;
            for(int i = 0; i < i1.Length; i++)
            {
                if (i1[i] == '.')
                {
                    MessageBox.Show("Can't perform Modulus operation on floating point value");
                    return;
                }
            }
            ii1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";

        }

        private void button18_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button13_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            op = "+";
            //bool cf = false;    //to find whether the text in the text box is float or not
            i1 = textBox1.Text;
            for(int i = 0; i < i1.Length; i++)
            {
                if (i1[i] == '.') //if there is a point it indicates floating point value
                {
                    cf = true;
                    break;
                }
            }
            if (cf)
            {
                fi1 = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                ii1 = Convert.ToInt32(textBox1.Text);
            }
            textBox1.Text = "";
        }
    }
}
