using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT_project
{
    public partial class FormAffine : Form
    {
        string ciphertext = string.Empty;
        public FormAffine()
        {
            InitializeComponent();
        }
        bool checkab()
        {
            if (!int.TryParse(textBox1.Text, out int n1)) { return false; }
            if (!int.TryParse(textBox2.Text, out int n2)) { return false; }

            // check UCLN giua a và 26
            n2 = 26;
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }

            if (n1 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkab())
            {
                string ciphertext = string.Empty;
                string plaintext = richTextBox1.Text;
                int.TryParse(textBox1.Text, out int a);
                int.TryParse(textBox2.Text, out int b);
                foreach (char ch in plaintext)
                {

                    if (char.IsLetter(ch))
                    {
                        char offset = char.IsUpper(ch) ? 'A' : 'a';

                        char encryptedChar = (char)(((a * (ch - offset) + b) % 26) + offset);
                        ciphertext += encryptedChar;
                    }
                    else
                    {
                        ciphertext += ch;
                    }
                }
                richTextBox2.Text = ciphertext;
            }
            else
            {
                MessageBox.Show("Không tồn tại giá trị nhich dao cua a do đó ko thể mã hoá ");
            }
        
    }
        public static int ModInverse(int a, int n)
        {
            int t1 = 0, t2 = 1, r1 = n, r2 = a;

            while (r2 > 0)
            {
                int q = r1 / r2;
                int r = r1 - q * r2;
                r1 = r2;
                r2 = r;

                int t = t1 - q * t2;
                t1 = t2;
                t2 = t;
            }

            if (r1 == 1) // UCLN(a,n)=1
            {
                return t1 < 0 ? t1 + n : t1;
            }
            else
            {
                throw new InvalidOperationException("Nghịch đảo module không tồn tại.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out int a);
            int.TryParse(textBox2.Text, out int b);
            int a1 = ModInverse(a, 26);
            //MessageBox.Show(a1.ToString());
            string ciphertext = richTextBox1.Text;
            string plaintext = string.Empty;
            foreach (char ch in ciphertext)
            {

                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';

                    char descryptedChar = (char)(((((ch - offset - b) + 26) % 26) * a1 % 26) + offset);
                    plaintext += descryptedChar;
                }
                else
                {
                    plaintext += ch;
                }
            }
            richTextBox2.Text = plaintext;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }


            private void saveToolStripMenuItem_Click(object sender, EventArgs e)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text File | *.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter st = new StreamWriter(saveFileDialog.FileName);
                    foreach (string t in richTextBox2.Lines)
                    {
                        st.WriteLine(t);
                    }
                    st.Close();
                }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(textBox1.Text, out int n1))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Không được để trống");
            }
            else if (!int.TryParse(textBox2.Text, out int n1))
            {
                MessageBox.Show("Chỉ nhập số nguyên ");
            }
        }
    }
}
