using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanal_klavye
{
    public partial class Form1 : Form
    {
        static int caps_durum = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//genel atama
        {
            int cursor = textBox1.SelectionStart;
            if (caps_durum == 0)
            {                
                if (cursor != textBox1.Text.Length)
                {
                    textBox1.Text = textBox1.Text.Insert(cursor, (sender as Button).Text.ToLower());              
                    textBox1.SelectionStart = cursor+1;
                    textBox1.Focus();
                }
                else
                {
                    textBox1.Text += (sender as Button).Text.ToLower();               
                    textBox1.SelectionStart = textBox1.Text.Length;
                    //textBox1.Focus();
                }
            }
            else
            {
                if (cursor != textBox1.Text.Length)
                {
                    textBox1.Text = textBox1.Text.Insert(cursor,(sender as Button).Text);
                    textBox1.SelectionStart = cursor+1;
                    textBox1.Focus();
                }
                else
                {
                    textBox1.Text += (sender as Button).Text;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.Focus();
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)//bir karakter silme
        {
            textBox1.Focus();
            int cursor = textBox1.SelectionStart;
            if (cursor != 0)
            {
                textBox1.Text = textBox1.Text.Remove(cursor - 1, 1);
                textBox1.SelectionStart = cursor - 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)//tamamen silme
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)//kopyalama
        {
            textBox1.Focus();
            int cursor = textBox1.SelectionStart;
            if(cursor!=0)
            Clipboard.SetText(textBox1.Text);          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // textBox1.Focus();
        }

        private void button33_Click(object sender, EventArgs e)//cursor sola
        {
            textBox1.Focus();
            int cursor = textBox1.SelectionStart;
            if(cursor!=0)
            textBox1.SelectionStart = cursor-1;
        }

        private void button32_Click(object sender, EventArgs e)//cursaor saga
        {
            textBox1.Focus();
            int cursor = textBox1.SelectionStart;
            textBox1.SelectionStart = cursor+1;
        }

        private void button73_Click(object sender, EventArgs e)//tab
        {
            int cursor = textBox1.SelectionStart;
            if (cursor != textBox1.Text.Length)
            {
                textBox1.Text = textBox1.Text.Insert(cursor, "     ");
                textBox1.SelectionStart = cursor+5;
                textBox1.Focus();
            }
            else
            {
                textBox1.Text += "     ";
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)//space
        {
            int cursor = textBox1.SelectionStart;
            if (cursor != textBox1.Text.Length)
            {
                textBox1.Text = textBox1.Text.Insert(cursor, " ");
                textBox1.SelectionStart = cursor+1;
                textBox1.Focus();
            }
            else
            {
                textBox1.Text += " ";
                textBox1.Focus();
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }

        private void button74_Click(object sender, EventArgs e)//caps
        {
            textBox1.Focus();
            int cursor = textBox1.SelectionStart;
            textBox1.SelectionStart = cursor;
            if (caps_durum == 0)
            {
                caps_durum = 1;
                caps_btn.BackColor = Color.Pink;
                label1.Visible = true;
            }
            else
            {
                caps_durum = 0;
                caps_btn.BackColor = Color.Gainsboro;
                label1.Visible = false;
            }
        }
    }
}
