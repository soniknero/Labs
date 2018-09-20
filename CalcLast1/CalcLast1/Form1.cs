using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFor4._6
{
    public partial class Form1 : Form
    {

        double a, b, c, sum, intBuf = 0;
        int count;
        bool znak = true, count1 = true;

        public Form1()
        {
            InitializeComponent();
            //дописать KeyPrev если что то пойдет не так
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);           
        }
        private void calculate()
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                switch (count)
                {
                    case 1:
                        b = double.Parse(textBox1.Text);
                        sum = a + b;
                        textBox2.Text = sum.ToString();
                        break;
                    case 2:
                        b = double.Parse(textBox1.Text);
                        sum = a - b;
                        textBox2.Text = sum.ToString();
                        break;
                    case 3:
                        b = double.Parse(textBox1.Text);
                        sum = a * b;
                        textBox2.Text = sum.ToString();
                        break;
                    case 4:
                        b = double.Parse(textBox1.Text);
                        sum = a / b;
                        textBox2.Text = sum.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 1;
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 2;
            else { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 3;
            else { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 4;
            else { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 5;
            else { }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 6;
            else { }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 7;
            else { }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 8;
            else { }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 9;
            else { }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
                textBox1.Text += 0;
            else { }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.MaxLength > textBox1.Text.Length)
            {
                if (textBox1.Text.Contains(","))
                { }
                else
                {
                    if (textBox1.Text == "")
                    {
                        textBox1.Text += "0,";
                    }
                    else
                        textBox1.Text += ",";
                }
            }
            else { }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                if (count1 == false)
                {
                    count = 1;
                    calculate();
                    textBox1.Text = sum.ToString();
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                if (count1 == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 1;
                    znak = true;
                    count1 = false;
                }
            }
            catch
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                if (count1 == false)
                {
                    count = 2;
                    calculate();
                    textBox1.Text = sum.ToString();
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                if (count1 == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 2;
                    znak = true;
                    count1 = false;
                }
            }
            catch
            {

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                if (count1 == false)
                {
                    count = 3;
                    calculate();
                    textBox1.Text = sum.ToString();
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                if (count1 == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 3;
                    znak = true;
                    count1 = false;
                }
            }
            catch { }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                if (count1 == false)
                {
                    count = 4;
                    calculate();
                    textBox1.Text = sum.ToString();
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                }
                if (count1 == true)
                {
                    a = double.Parse(textBox1.Text);
                    textBox1.Clear();
                    count = 4;
                    znak = true;
                    count1 = false;
                }
            }
            catch { }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            calculate();
            textBox1.Clear();
            count1 = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                c = double.Parse(textBox1.Text);
                c = 1 / c;
                textBox1.Text = c.ToString();
            }
            catch { }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                c = double.Parse(textBox1.Text);
                c = c * c;
                textBox1.Text = c.ToString();
            }
            catch { }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                c = double.Parse(textBox1.Text);
                c = Math.Sqrt(c);
                textBox1.Text = c.ToString();
            }
            catch { }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                intBuf = double.Parse(textBox1.Text);
                b = double.Parse(textBox1.Text);
                c = a * b / 100;
                textBox1.Text = c.ToString();
                calculate();
            }
            catch { }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.NumPad0:
                    {
                        button10_Click(0, e);
                        break;
                    }
                case Keys.NumPad1:
                    {
                        button1_Click(0, e);
                        break;
                    }
                case Keys.NumPad2:
                    {
                        button2_Click(0, e);
                        break;
                    }
                case Keys.NumPad3:
                    {
                        button3_Click(0, e);
                        break;
                    }
                case Keys.NumPad4:
                    {
                        button4_Click(0, e);
                        break;
                    }
                case Keys.NumPad5:
                    {
                        button5_Click(0, e);
                        break;
                    }
                case Keys.NumPad6:
                    {
                        button6_Click(0, e);
                        break;
                    }
                case Keys.NumPad7:
                    {
                        button7_Click(0, e);
                        break;
                    }
                case Keys.NumPad8:
                    {
                        button8_Click(0, e);
                        break;
                    }
                case Keys.NumPad9:
                    {
                        button9_Click(0, e);
                        break;
                    }
                case Keys.Add:
                    {
                        button12_Click(0,e);
                        break;
                    }
                case Keys.Subtract:
                    {
                        button13_Click(0, e);
                        break;
                    }
                case Keys.Multiply:
                    {
                        button14_Click(0, e);
                        break;
                    }
                case Keys.Divide:
                    {
                        button15_Click(0, e);
                        break;
                    }                
                case Keys.Decimal:
                    {
                        button11_Click(0, e);
                        break;
                    }
                case Keys.Back:
                    {
                        button16_Click(0, e);
                        break;
                    }
               /* case Keys.Enter:
                    {
                        button23_Click(0, e);
                        break;
                    }*/
                default: break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) button23.PerformClick();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            a = 0;
            b = 0;
            c = 0;
            count1 = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //form activate

        }
    }
}
