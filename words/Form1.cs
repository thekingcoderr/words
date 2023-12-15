using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace words
{
    public partial class Form1 : Form
    {
        List<string> words = new List<string>();
        
        
        string combine = "";
        char[] chars = new char[8];
        int top = 0;
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> wordlist = new List<String>();
            StreamReader file = new StreamReader("../../resources/ukenglish.txt");
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    wordlist.Add(ln);
                }
                file.Close();
            }
            for(int i = 0; i < wordlist.Count;i++)
            {
                words.Add(wordlist[i]);
            }
            
            

            Random rnd = new Random();
            char[] s = new char[4];
            for (int i = 0; i < 4; i++)
            {
                int letter = rnd.Next(0, 20);
                string letters = "BCDFGHGKLMNPQRSTVWXYZ";
                s[i] = letters[letter];
            }
            button1.Text = Convert.ToString(s[0]);
            button2.Text = Convert.ToString(s[1]);
            button3.Text = Convert.ToString(s[2]);
            button4.Text = Convert.ToString(s[3]);

            char[] vowel = new char[2];
            for (int i = 0; i < 2; i++)
            {
                string v = "AEIOU";
                int vowels = rnd.Next(0, 4);
                vowel[i] = v[vowels];
            }
            button5.Text = Convert.ToString(vowel[0]);
            button6.Text = Convert.ToString(vowel[1]);

            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            






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

        private void button1_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button1.Text;
            }
            else if (top == 1)
            {
                button8.Text = button1.Text;
            }
            else if (top == 2)
            {
                button9.Text = button1.Text;
            }
            else if (top == 3)
            {
                button10.Text = button1.Text;
            }
            else if (top == 4)
            {
                button11.Text = button1.Text;
            }
            else if (top == 5)
            {
                button12.Text = button1.Text;
                
            }
            chars[top] = Convert.ToChar(button1.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
                score(combine, words);
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button2.Text;
            }
            else if (top == 1)
            {
                button8.Text = button2.Text;
            }
            else if (top == 2)
            {
                button9.Text = button2.Text;
            }
            else if (top == 3)
            {
                button10.Text = button2.Text;
            }
            else if (top == 4)
            {
                button11.Text = button2.Text;
            }
            else if (top == 5)
            {
                button12.Text = button2.Text;
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
            }
            chars[top] = Convert.ToChar(button2.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
                score(combine, words);
            }
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button3.Text;
            }
            else if (top == 1)
            {
                button8.Text = button3.Text;
            }
            else if (top == 2)
            {
                button9.Text = button3.Text;
            }
            else if (top == 3)
            {
                button10.Text = button3.Text;
            }
            else if (top == 4)
            {
                button11.Text = button3.Text;
            }
            else if (top == 5)
            {
                button12.Text = button3.Text;
            }
            chars[top] = Convert.ToChar(button3.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
                score(combine, words);
            }
            



        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button4.Text;
            }
            else if (top == 1)
            {
                button8.Text = button4.Text;
            }
            else if (top == 2)
            {
                button9.Text = button4.Text;
            }
            else if (top == 3)
            {
                button10.Text = button4.Text;
            }
            else if (top == 4)
            {
                button11.Text = button4.Text;
            }
            else if (top == 5)
            {
                button12.Text = button4.Text;

            }
            chars[top] = Convert.ToChar(button4.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
                score(combine, words);
            }
            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button5.Text;
            }
            else if (top == 1)
            {
                button8.Text = button5.Text;
            }
            else if (top == 2)
            {
                button9.Text = button5.Text;
            }
            else if (top == 3)
            {
                button10.Text = button5.Text;
            }
            else if (top == 4)
            {
                button11.Text = button5.Text;
            }
            else if (top == 5)
            {
                button12.Text = button5.Text;
                score(combine, words);

            }
            chars[top] = Convert.ToChar(button5.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
            }
            



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (top == 0)
            {
                button7.Text = button6.Text;
            }
            else if (top == 1)
            {
                button8.Text = button6.Text;
            }
            else if (top == 2)
            {
                button9.Text = button6.Text;
            }
            else if (top == 3)
            {
                button10.Text = button6.Text;
            }
            else if (top == 4)
            {
                button11.Text = button6.Text;
            }
            else if (top == 5)
            {
                button12.Text = button6.Text;
  
            }
            chars[top] = Convert.ToChar(button6.Text);
            top = top + 1;
            if (top == 6)
            {
                combine = Convert.ToString(chars[0]) + Convert.ToString(chars[1]) + Convert.ToString(chars[2]) + Convert.ToString(chars[3]) + Convert.ToString(chars[4]) + Convert.ToString(chars[5]);
                button13.Text = combine;
                score(combine, words);
            }
            



        }
        public static void score(string combine,List<string> words)
        {
            for(int i = 0; i < words.Count;i++)
            {
                if (words[i] == combine)
                {
                    MessageBox.Show("well done");
                    break;
                }
                else
                {
                    MessageBox.Show("wrong");
                    break;
                }
            }
        }
    }
}
