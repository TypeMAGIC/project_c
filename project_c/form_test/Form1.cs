using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_test
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textbox_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "hello world";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "이것은 테스트를 위한 메시지";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "난 그냥 라벨일 뿐이야";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "\"체크\"";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "고오오오오오오오오야아아아아아아아아앙이이이이이이";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "UP and DOWN";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "글자가 바뀌었다!";
        }
    }
}
