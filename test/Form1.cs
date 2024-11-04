using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent(); 
            
        }       

        public static int GetPriority(string op)
        {
            if (op == "*" || op == "/" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }
        public static string FormatExpression(ref string expression)
        {
            expression = expression.Replace(" ", "");

            expression = Regex.Replace(expression, @"\+|\-|\*|\/|\%|\^|\)|\(", delegate (Match match)
            {
                return " " + match.Value + " ";
            });

            expression = expression.Replace("  ", " ");
            expression = expression.Trim();
            return expression;
        }
        private static bool IsOperator(string str)
        {
            return Regex.Match(str, @"\+|\-|\*|\/|\%").Success;
        }
        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
        public static string Infix2Postfix(string infix)
        {
            FormatExpression(ref infix);

            IEnumerable<string> str = infix.Split(' ');
            Stack<string> stack = new Stack<string>();
            StringBuilder postfix = new StringBuilder();

            foreach (string s in str)
            {
                if (IsOperand(s))
                    postfix.Append(s).Append(" ");
                else if (s == "(")
                    stack.Push(s);
                else if (s == ")")
                {
                    string x = stack.Pop();
                    while (x != "(")
                    {
                        postfix.Append(x).Append(" ");
                        x = stack.Pop();
                    }
                }
                else// IsOperator(s)
                {
                    while (stack.Count > 0 && GetPriority(s) <= GetPriority(stack.Peek()))
                        postfix.Append(stack.Pop()).Append(" ");
                    stack.Push(s);
                }
            }

            while (stack.Count > 0)
                postfix.Append(stack.Pop()).Append(" ");

            return postfix.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string t = textBox1.Text;
            textBox2.Text = Infix2Postfix(t);
        }
    }
}
