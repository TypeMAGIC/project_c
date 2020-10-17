using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Lotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public int input(int[] arr, int i)
        {
            Random r = new Random();
            arr[i] = r.Next(1, 45);
            for (int j = 0; j < 6; j++)
            {
                if (arr[j] == arr[i])
                {
                    arr[i] = r.Next(1, 45);
                }
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = { 0, };

            for (int i = 0; i < 6; i++)
            {
                input(arr, i);
            }

            R1.Text = arr[0].ToString();
            R2.Text = arr[1].ToString();
            R3.Text = arr[2].ToString();
            R4.Text = arr[3].ToString();
            R5.Text = arr[4].ToString();
            R6.Text = arr[5].ToString();
            
            button1.Visible = false;
        }
    }
}
