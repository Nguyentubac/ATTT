using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATTT_project
{
    
    public partial class FormHill : Form
    {
        private double[,] keyMatrix;
        private double[,] invertkeyMatrix;
        private double detK_1 = 0;
        private int size_matrix = 0;                  
        public FormHill()
        {
            InitializeComponent();
            comboBox1.Items.Add("Ma trận 2x2");
            comboBox1.Items.Add("Ma trận 3x3");
            comboBox1.Items.Add("Ma trận 4x4");
            comboBox1.Text = "--Chọn loại ma trận--";

        }
        public double[,] setkeyMatrix()
        {
            double.TryParse(textBox1.Text, out double num1);
            double.TryParse(textBox2.Text, out double num2);
            double.TryParse(textBox3.Text, out double num3);
            double.TryParse(textBox4.Text, out double num4);
            double.TryParse(textBox5.Text, out double num5);
            double.TryParse(textBox6.Text, out double num6);
            double.TryParse(textBox7.Text, out double num7);
            double.TryParse(textBox8.Text, out double num8);
            double.TryParse(textBox9.Text, out double num9);
            double.TryParse(textBox10.Text, out double num10);
            double.TryParse(textBox11.Text, out double num11);
            double.TryParse(textBox12.Text, out double num12);
            double.TryParse(textBox13.Text, out double num13);
            double.TryParse(textBox14.Text, out double num14);
            double.TryParse(textBox15.Text, out double num15);
            double.TryParse(textBox16.Text, out double num16);
            
            switch (comboBox1.SelectedIndex)
            {
                case 0: size_matrix = 2;
                    keyMatrix = new double[,] { { num1, num2}, { num5, num6 } };
                    break;
                case 1: size_matrix = 3;
                    keyMatrix = new double[,] { { num1, num2, num3 }, { num5, num6, num7 },{num9, num10, num11} };
                    break;
                case 2: size_matrix = 4;
                    keyMatrix = new double[,] { { num1, num2, num3, num4}, { num5, num6, num7, num8 }, 
                                           { num9, num10, num11, num12 },{num13, num14, num15, num16} };
                    break;
            };
            return keyMatrix;
        }
        public string Encrypt(string plaintext)
        {
            plaintext = plaintext.ToUpper().Replace(" ", "");
            while (plaintext.Length % size_matrix != 0)
            {
                plaintext += "X"; 
            }
            string ciphertext = "";

            for (int i = 0; i < plaintext.Length; i += size_matrix)
            {
                double[] vector = new double[size_matrix];

                for (int j = 0; j < size_matrix; j++)
                {
                    vector[j] = plaintext[i + j] - 'A'; // Convert to Z_26
                }
                
                double[] result = MultiplyMatrix(keyMatrix,vector); // MultiplyMatrix
                
                //MessageBox.Show(result[0].ToString() + result[1].ToString() + result[2].ToString());
                foreach (var value in result)
                {
                    ciphertext += (char)((value % 26) + 'A'); // Convert to char
                }
            }
            return ciphertext;
        }
        public string Decrypt(string ciphertext)
        {
            double[,] inverseKeyMatrix = invertkeyMatrix;// Z_26
            for(int i = 0; i < size_matrix; i++)
            {
                for(int j = 0;j < size_matrix; j++)
                {
                    inverseKeyMatrix[i, j] *= detK_1;  
                }
            }

            Z_26(inverseKeyMatrix);

            string plaintext = "";

            for (int i = 0; i < ciphertext.Length; i += size_matrix)
            {
                double[] vector = new double[size_matrix];
                for (int j = 0; j < size_matrix; j++)
                {
                    vector[j] = ciphertext[i + j] - 'A'; // Convert char to Z_26
                }
                // bugs
                double[] result = MultiplyMatrix(inverseKeyMatrix, vector);

                foreach (var value in result)
                {
                    plaintext += (char)((value % 26 + 26) % 26 + 'A'); // Convert back to char
                }
            }
            return plaintext.TrimEnd('X');
        }
        private double[] MultiplyMatrix(double[,] matrix, double[] vector)
        {
            double[] result = new double[size_matrix];

            for (int i = 0; i < size_matrix; i++)
            {
                result[i] = 0;
                for (int j = 0; j < size_matrix; j++) 
                {
                    //result[i] += matrix[i, j] * vector[j];
                    result[i] += vector[j] * matrix[j, i];
                }
                result[i] %= 26;
            }
            return result;
        }

        static void Z_26(double[,] matrix)
        {
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0;j < 2; j++)
                {
                    while(matrix[i,j] < 0)
                    {
                        matrix[i, j] += 26;
                    }
                    matrix[i, j] %= 26;
                }
            }
        }
        
        static double Determinant(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            // cơ bản n = 1
            if (n == 1)
            {
                return matrix[0, 0];
            }
            //co bản n = 2;
            if (n == 2)
            {
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            }
            //n > = 3;
            double det = 0;  // đã test ok
            for (int j = 0; j < n; j++)
            {
                double[,] matran_con = Matran_con(matrix, 0, j);
                det += Math.Pow(-1, j) * matrix[0, j] * Determinant(matran_con);
            }

            return det;
        }
        static double[,] GetAdjugate(double[,] matrix) // ma trận phụ hợp  oke rồi nhé
        {
            int n = matrix.GetLength(0);
            double[,] adjugate = new double[n, n]; // Ma trận phụ hợp có cùng kích thước với ma trận gốc

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) // đã test ok 
                {
                    double[,] matran_con = Matran_con(matrix, i, j);
                    double det = Determinant(matran_con);
                    //adjugate[j, i] = Math.Pow(-1, i + j) * det;  // K*
                    adjugate[j,i] = Math.Pow(-1, i + j) * det;  // K*
                }
            }
            Z_26(adjugate);
            return adjugate;
        }

        static double[,] Matran_con(double[,] matrix, int row, int col)
        {
            int n = matrix.GetLength(0);
            double[,] matran_con = new double[n - 1, n - 1];
            int matran_conRow = 0, matran_conCol;

            for (int i = 0; i < n; i++)
            {
                if (i == row) continue; // Bỏ qua hàng đã chọn

                matran_conCol = 0;
                for (int j = 0; j < n; j++)
                {
                    if (j == col) continue; // Bỏ qua cột đã chọn

                    matran_con[matran_conRow, matran_conCol] = matrix[i, j];
                    matran_conCol++;
                }
                matran_conRow++;
            }
            return matran_con;
        }

        bool checkUCLN(double det)
        {
            // check UCLN giua a và 26
            double n1 = det;
            double n2 = 26;
            while (n2 != 0)
            {
                double temp = n2;
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
        public static double ModInverse(double a, int n)
        {
            double t1 = 0, t2 = 1, r1 = n, r2 = a;

            while (r2 > 0)
            {
                int q = (int)((int)r1 / r2);
                double r = r1 - q * r2;
                r1 = r2;
                r2 = r;

                double t = t1 - q * t2;
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
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            setkeyMatrix(); // tạo ma trận 
                            // tính định thức , UCLN (detK, 26)= 1 (t/m); <> tồn tại detK^-1

            double detK = Determinant(setkeyMatrix()); // tính DetK
            detK_1 = ModInverse(detK,26);

            if (checkUCLN(detK)){  // check UCLN(detK , 26)\

                invertkeyMatrix = GetAdjugate(keyMatrix); //ma trận phụ hợp
                richTextBox2.Text = "";
                richTextBox2.Text = Encrypt(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Ma trận không tồn tại ma trận nghịch đảo");
            }
            
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    size_matrix = 2;
                    // Enable
                    textBox1.Text = "";textBox1.Enabled = true;
                    textBox2.Text = "";textBox2.Enabled = true;
                    textBox5.Text = "";textBox5.Enabled = true;
                    textBox6.Text = "";textBox6.Enabled = true;
                    //Disable
                    textBox3.Text = "";textBox3.Enabled = false;
                    textBox4.Text = "";textBox4.Enabled = false;
                    textBox7.Text = "";textBox7.Enabled = false;
                    textBox8.Text = "";textBox8.Enabled = false;
                    textBox9.Text = "";textBox9.Enabled = false;
                    textBox10.Text = "";textBox10.Enabled = false;
                    textBox11.Text = "";textBox11.Enabled = false;
                    textBox12.Text = "";textBox12.Enabled = false;
                    textBox13.Text = "";textBox13.Enabled = false;
                    textBox14.Text = "";textBox14.Enabled = false;
                    textBox15.Text = "";textBox15.Enabled = false;
                    textBox16.Text = "";textBox16.Enabled = false;
                    break;
                case 1:
                    size_matrix = 3;
                    // Enable
                    textBox1.Text = ""; textBox1.Enabled = true;
                    textBox2.Text = ""; textBox2.Enabled = true;
                    textBox3.Text = ""; textBox3.Enabled = true;
                    textBox5.Text = ""; textBox5.Enabled = true;
                    textBox6.Text = ""; textBox6.Enabled = true;
                    textBox7.Text = ""; textBox7.Enabled = true;
                    textBox9.Text = ""; textBox9.Enabled = true;
                    textBox10.Text = ""; textBox10.Enabled = true;
                    textBox11.Text = ""; textBox11.Enabled = true;
                    //Disable
                    textBox4.Text = ""; textBox4.Enabled = false;
                    textBox8.Text = ""; textBox8.Enabled = false;
                    textBox12.Text = ""; textBox12.Enabled = false;
                    textBox13.Text = ""; textBox13.Enabled = false;
                    textBox14.Text = ""; textBox14.Enabled = false;
                    textBox15.Text = ""; textBox15.Enabled = false;
                    textBox16.Text = ""; textBox16.Enabled = false;
                    break;
                case 2:
                    size_matrix = 4;
                    // Enable
                    textBox1.Text = ""; textBox1.Enabled = true;
                    textBox2.Text = ""; textBox2.Enabled = true;
                    textBox3.Text = ""; textBox3.Enabled = true;
                    textBox4.Text = ""; textBox4.Enabled = true;
                    textBox5.Text = ""; textBox5.Enabled = true;
                    textBox6.Text = ""; textBox6.Enabled = true;
                    textBox7.Text = ""; textBox7.Enabled = true;
                    textBox8.Text = ""; textBox8.Enabled = true;
                    textBox9.Text = ""; textBox9.Enabled = true;
                    textBox10.Text = ""; textBox10.Enabled = true;
                    textBox11.Text = ""; textBox11.Enabled = true;
                    textBox12.Text = ""; textBox12.Enabled = true;
                    textBox13.Text = ""; textBox13.Enabled = true;
                    textBox14.Text = ""; textBox14.Enabled = true;
                    textBox15.Text = ""; textBox15.Enabled = true;
                    textBox16.Text = ""; textBox16.Enabled = true;
                    break;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
                richTextBox2.Text = "";
                richTextBox2.Text = Decrypt(richTextBox1.Text);
        }
    }
}
