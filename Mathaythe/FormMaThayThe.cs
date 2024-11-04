using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathaythe
{
    public partial class FormMaThayThe : Form
    {
        public FormMaThayThe()
        {
            InitializeComponent();
        }

        private const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string mathaythe;
        private void gen_thaythe_Click(object sender, EventArgs e)
        {
            string keytutao = TaoMangaunhien();
            Key_thaythe.Text = keytutao;
        }
        static string TaoMangaunhien()
        {
            Random rnd = new Random();
            char[] cipher = alphabet.ToCharArray();

            for (int i = cipher.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                char temp = cipher[i];
                cipher[i] = cipher[j];
                cipher[j] = temp;
            }
            return new string(cipher);
        }

        public static string Mahoa(string ma)
        {
            ma = ma.ToUpper();
            string mahoa = "";

            foreach (char c in ma)
            {
                if (char.IsLetter(c))
                {
                    int index = alphabet.IndexOf(c);
                    mahoa += mathaythe[index];
                }
                else
                {
                    mahoa += c;
                }
            }

            return mahoa;
        }


        public static string giaima(string mahoa)
        {
            mahoa = mahoa.ToUpper();
            string ma = "";

            foreach (char c in mahoa)
            {
                if (char.IsLetter(c))
                {
                    int index = mathaythe.IndexOf(c);
                    ma += alphabet[index];
                }
                else
                {
                    ma += c;
                }
            }

            return ma;
        }

        static bool kiemtrathaythe(string keythaythe)
        {

            if (keythaythe.Length != 26)
            {
                MessageBox.Show("Mã thay thế phải chứa đúng 26 ký tự.");
                return false;
            }

            string upperCipher = keythaythe.ToUpper();

            if (!upperCipher.All(char.IsLetter))
            {
                MessageBox.Show("Mã thay thế chỉ được chứa các chữ cái từ A đến Z.");
                return false;
            }

            var soluong = new HashSet<char>(upperCipher);
            if (soluong.Count != 26)
            {
                MessageBox.Show("Mã thay thế không được chứa các ký tự trùng lặp.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = thongdiep_thaythe.Text;
            if (Key_thaythe.Text == "")
            {
                gen_thaythe_Click(sender, e);
            }
            mathaythe = Key_thaythe.Text.ToString();

            if (kiemtrathaythe(mathaythe))
            {
                if (thucthi_thaythe.SelectedItem.Equals("Mã hóa"))
                {
                    ketqua_thaythe.Text = Mahoa(str);
                }

                else if (thucthi_thaythe.SelectedItem.Equals("Giải mã"))
                {
                    ketqua_thaythe.Text = giaima(str);
                }
            }
        }
    }
}
