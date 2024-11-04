using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vigenere
{
    public partial class FormVigenere : Form
    {
        public FormVigenere()
        {
            InitializeComponent();
        }

        private void btn_mh_Click(object sender, EventArgs e)
        {
            string input = txt_input.Text;
            string key = txt_key.Text;
            if (ktrakt(key))
            {

                txt_output.Text = mahoa(input, key);
            }
            else
            {
                MessageBox.Show("Chỉ được nhập key là ký tự chữ cái");
            }
        }

        private void btn_gm_Click(object sender, EventArgs e)
        {
            string key = txt_key.Text;
            string input = txt_input.Text;
            if (ktrakt(key))
            {

                txt_output.Text = giaima(input, key);
            }
            else
            {
                MessageBox.Show("Chỉ được nhập key là ký tự");
            }
        }

        public bool ktrakt(string key)
        {
                if (!key.All(Char.IsLetter))
                {
                    txt_key.Clear();
                    return false;
                }
                else
                {
                    return true;
                }
                
        }
        public string mahoa(string a, string key)
        {
            string z = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char ch in a)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char m = key[keyIndex % key.Length];

                    char y = (char)((((ch - offset) + (m - 'A')) % 26) + offset);
                    z += y;

                    keyIndex++;
                }
                else
                {
                    z += ch;
                }
            }

            return z;
        }
        public string giaima(string z, string key)
        {
            string a = "";
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char ch in z)
            {
                if (char.IsLetter(ch))
                {
                    char offset = char.IsUpper(ch) ? 'A' : 'a';
                    char m = key[keyIndex % key.Length];


                    char x = (char)((((ch - offset) - (m - 'A') + 26) % 26) + offset);
                    a += x;

                    keyIndex++;
                }
                else
                {
                    a += ch;
                }
            }

            return a;
        }
    }
}
