using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words
{
    public partial class Form1 : Form
    {
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            char[] s = new char[4];
            for (int i = 0; i < 4; i++)
            {
                int letter = rnd.Next(0, 20);
                string letters = "BCDFGHGKLMNPQRSTVWXYZ";
                s[i] = letters[letter];
            }
            richTextBox1.Text = Convert.ToString(s[0]);
            richTextBox2.Text = Convert.ToString(s[1]);
            richTextBox3.Text = Convert.ToString(s[2]);
            richTextBox4.Text = Convert.ToString(s[3]);

            char[] vowel = new char[2];
            for (int i = 0; i < 2; i++)
            {
                string v = "AEIOU";
                int vowels = rnd.Next(0, 4);


            }



        }
        static void randomletters()
        {
           
  
        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
