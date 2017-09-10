using System;
using System.Windows.Forms;

namespace GoldenSearchMethod
{
    public partial class iteration : Form
    {
        public iteration()
        {
            InitializeComponent();
            
        }
     
        public String[] it1 = new String[100];
        private void Form2_Load(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void str(String [] it)
        {
            for (int i = 0; i < it.Length; i++)
            {
                richTextBox1.Text = richTextBox1.Text + it[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}