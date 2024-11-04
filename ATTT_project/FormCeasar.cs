using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ceasar
{
    public partial class FormCeasar : Form
    {
        public FormCeasar()
        {
            InitializeComponent();
        }

        private void check_caesar_Click(object sender, EventArgs e)
        {
            string str = input_caesar.Text;
            string key = key_caesar.Text.ToString();
            int k = Convert.ToInt32(key);
            if (thucthi_caesar.SelectedItem.Equals("Mã hóa"))
            {
                output_caesar.Text = mahoa(str, k);
            }

            else if (thucthi_caesar.SelectedItem.Equals("Giải mã"))
            {
                output_caesar.Text = giaima(str, k);
            }

        }

        public static string mahoa(string str, int k)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 'A' && charArray[i] <= 'Z')
                {
                    charArray[i] = upper_mahoa(charArray[i], k);
                }
                else if (charArray[i] >= 'a' && charArray[i] <= 'z')
                {
                    charArray[i] = lower_mahoa(charArray[i], k);
                }
               
            }

            string stringword = new string(charArray);
            return stringword;
        }

        public static char upper_mahoa(char a, int b)
        {



            b = b % 26;
            a = (char)(a + b);

            if (a > 'Z')
            {
                a = (char)(a - 26);
            }

            else if (a < 'A')
            {
                a = (char)(a + 26);
            }

            return (char)a;
        }

        public static char lower_mahoa(char a, int b)
        {

            b = b % 26;
            a = (char)(a + b);

            if (a > 'z')
            {
                a = (char)(a - 26);
            }

            else if (a < 'a')
            {
                a = (char)(a + 26);
            }

            return (char)a;
        }

        public static string giaima(string str, int k)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 'A' && charArray[i] <= 'Z')
                {
                    charArray[i] = upper_giaima(charArray[i], k);
                }
                else if (charArray[i] >= 'a' && charArray[i] <= 'z')
                {
                    charArray[i] = lower_giaima(charArray[i], k);
                }
            }
            string stringword = new string(charArray);
            return stringword;
        }

        public static char upper_giaima(char a, int b)
        {


            b = b % 26;
            a = (char)(a - b);

            if (a < 'A')
            {
                a = (char)(a + 26);
            }
            else if (a > 'Z')
            {
                a = (char)(a - 26);
            }
            return (char)a;
        }

        public static char lower_giaima(char a, int b)
        {
            b = b % 26;
            a = (char)(a - b);
            if (a < 'a')
            {
                a = (char)(a + 26);
            }
            else if (a > 'z')
            {
                a = (char)(a - 26);
            }
            return (char)a;
        }

        private void thucthi_caesar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormCeasar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
