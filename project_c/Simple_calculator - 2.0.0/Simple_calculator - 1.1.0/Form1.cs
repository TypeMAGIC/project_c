using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Simple_calculator
{
    public partial class Calculator : Form
    {
        long a = -1;
        long a_s = -1;
        long b = -1;
        int sym_w = -1;
        int sym_s = -1;
        string sym = "+-×÷^";


        public Calculator()
        {
            InitializeComponent();
        }

        public void input_num(int num)
        {
            if (sym_w == -1)
            {
                a = num;
                result_box.Text = a.ToString();
            }
            else
            {
                b = num;
                result_box.Text = a.ToString() + sym[sym_w] + b.ToString();
            }
        }

        public void input_sym(int num)
        {
            if (b == -1)
            {
                if (num == 4)
                {
                    b = 2;
                    sym_s = num;
                    sym_w = num;
                    result_box.Text = a.ToString() + sym[sym_w] + b.ToString();
                }
                else
                {
                    sym_s = num;
                    sym_w = num;
                    result_box.Text = a.ToString() + sym[sym_w];
                }
            }
            else
            {
                if (num == 4)
                {
                    b = 2;
                    sym_s = num;
                    sym_w = num;
                    result_box.Text = a.ToString() + sym[sym_w] + b.ToString();
                }
                else
                {
                    b = -1;
                    sym_s = num;
                    sym_w = num;
                    result_box.Text = a.ToString() + sym[sym_w];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            switch (sym_w)
            {
                case -1:
                    switch (sym_s)
                    {
                        case 0:
                            if (b == -1)
                            {
                                b = 0;
                            }
                            a += b;
                            break;
                        case 1:
                            if (b == -1)
                            {
                                b = 0;
                            }
                            a -= b;
                            break;
                        case 2:
                            if (b == -1)
                            {
                                b = 1;
                            }
                            a *= b;
                            break;
                        case 3:
                            if (b == -1)
                            {
                                b = 1;
                            }
                            else if (b == 0)
                            {
                                a = 0;
                                break;
                            }
                            a /= b;
                            break;
                        case 4:
                            a_s = a;
                            for (int i = 0; i < b - 1; i++)
                            {
                                a *= a_s;
                            }
                            break;
                    }
                    break;
                case 0:
                    if (b == -1)
                    {
                        b = 0;
                    }
                    a += b;
                    break;
                case 1:
                    if (b == -1)
                    {
                        b = 0;
                    }
                    a -= b;
                    break;
                case 2:
                    if (b == -1)
                    {
                        b = 1;
                    }
                    a *= b;
                    break;
                case 3:
                    if (b == -1)
                    {
                        b = 1;
                    }
                    else if (b == 0)
                    {
                        a = 0;
                        break;
                    }
                    a /= b;
                    break;
                case 4:
                    a_s = a;
                    for(int i = 0; i < b-1; i++)
                    {
                        a *= a_s;
                    }
                    break;
            }
            result_box.Text = a.ToString();
            b = -1;
            sym_w = -1;
        }

        private void result_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            input_num(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input_num(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input_num(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input_num(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input_num(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input_num(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input_num(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input_num(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input_num(9);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            input_sym(0);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            input_sym(1);
        }

        private void Multiple_Click(object sender, EventArgs e)
        {
            input_sym(2);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            input_sym(3);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            a = -1;
            b = -1;
            sym_w = -1;
            result_box.Text = "";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (b != -1)
            {
                b = -1;
                result_box.Text = a.ToString() + sym[sym_w];
            }
            else if (sym_w != -1)
            {
                sym_w = -1;
                result_box.Text = a.ToString();
            }
            else
            {
                a = -1;
                result_box.Text = "";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            input_num(0);
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            input_sym(4);
        }
    }
}
