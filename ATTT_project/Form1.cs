using ATTT;
using Ceasar;
using Mathaythe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using vigenere;

namespace ATTT_project
{
    public partial class Form1 : Form
    {   
        bool ktf1 = false;
        bool ktf2 = false;
        bool ktf3 = false;
        bool ktf4 = false;
        bool ktf5 = false;
        bool ktf6 = false;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void affineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormAffine)
                {
                    child.BringToFront();
                    ktf1 = true;
                }
            }
            if (!ktf1 && !ktf2)
            {
                FormAffine f1 = new FormAffine();
                f1.MdiParent = this;
                f1.Show();
                ktf1 = true;
            }
            else
            {
                ktf1 = false;
            }
        }



        private void ceasarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCeasar f2 = new FormCeasar();
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormCeasar)
                {
                    child.BringToFront();
                    ktf2 = true;
                }
            }
            if (!ktf2)
            {
                
                f2.MdiParent = this;
                f2.Show();

            }
            else if(f2.IsDisposed == true)
            {
                ktf2 = false;
            }
        }
        private void maThayTheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormMaThayThe)
                {
                    child.BringToFront();
                    ktf3 = true;
                }
            }

            if (!ktf3)
            {
                FormMaThayThe f3 = new FormMaThayThe();
                f3.BringToFront();
                f3.MdiParent = this;
                f3.Show();
            }
            else
            {
                ktf3 = false;
            }
        }

        private void playfairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormAffine)
                {
                    child.BringToFront();
                    ktf4 = true;
                }
            }
            if (!ktf4)
            {
                FormPlayFair f4 = new FormPlayFair();
                f4.MdiParent = this;
                f4.BringToFront();
                f4.Show();
            }
            else
            {
                ktf4= false;
            }

        }

        private void vigennereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormVigenere)
                {
                    child.BringToFront();
                    ktf4 = true;
                }
            }
            if (!ktf4)
            {
                FormVigenere f5 = new FormVigenere();
                f5.MdiParent = this;
                f5.BringToFront();
                f5.Show();
            }
            else
            {
                ktf5 = false;
            }

        }

        private void rSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hillToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is FormHill)
                {
                    child.BringToFront();
                    ktf6 = true;
                }
            }
            if (!ktf6)
            {
                FormHill f6 = new FormHill();
                f6.MdiParent = this;
                f6.BringToFront();
                f6.Show();
            }
            else
            {
                ktf6 = false;
            }
        }
    }
}
