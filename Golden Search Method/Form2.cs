using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
     
        public String[] it1 = new String[100];
        private void Form2_Load(object sender, EventArgs e)
        {
           // it1 = frm1.it;
            
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
            /*for (int i = 0; i < it1.Length; i++)
            {

                richTextBox1.Text = richTextBox1.Text + it1[i];
           }*/
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