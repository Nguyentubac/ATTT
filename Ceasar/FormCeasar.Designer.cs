namespace Ceasar
{
    partial class FormCeasar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_caesar = new System.Windows.Forms.TextBox();
            this.output_caesar = new System.Windows.Forms.TextBox();
            this.key_caesar = new System.Windows.Forms.TextBox();
            this.thucthi_caesar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_caesar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_caesar
            // 
            this.input_caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_caesar.Location = new System.Drawing.Point(38, 77);
            this.input_caesar.Name = "input_caesar";
            this.input_caesar.Size = new System.Drawing.Size(313, 31);
            this.input_caesar.TabIndex = 0;
            // 
            // output_caesar
            // 
            this.output_caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_caesar.Location = new System.Drawing.Point(438, 77);
            this.output_caesar.Name = "output_caesar";
            this.output_caesar.Size = new System.Drawing.Size(315, 31);
            this.output_caesar.TabIndex = 1;
            // 
            // key_caesar
            // 
            this.key_caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_caesar.Location = new System.Drawing.Point(34, 173);
            this.key_caesar.Name = "key_caesar";
            this.key_caesar.Size = new System.Drawing.Size(121, 31);
            this.key_caesar.TabIndex = 2;
            // 
            // thucthi_caesar
            // 
            this.thucthi_caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thucthi_caesar.FormattingEnabled = true;
            this.thucthi_caesar.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.thucthi_caesar.Location = new System.Drawing.Point(38, 288);
            this.thucthi_caesar.Name = "thucthi_caesar";
            this.thucthi_caesar.Size = new System.Drawing.Size(169, 33);
            this.thucthi_caesar.TabIndex = 3;
            this.thucthi_caesar.Text = "Mã Hóa";
            this.thucthi_caesar.SelectedIndexChanged += new System.EventHandler(this.thucthi_caesar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập thông điệp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giá trị trả về";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thực hiện";
            // 
            // check_caesar
            // 
            this.check_caesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_caesar.Location = new System.Drawing.Point(438, 213);
            this.check_caesar.Name = "check_caesar";
            this.check_caesar.Size = new System.Drawing.Size(186, 49);
            this.check_caesar.TabIndex = 8;
            this.check_caesar.Text = "Xác Nhận";
            this.check_caesar.UseVisualStyleBackColor = true;
            this.check_caesar.Click += new System.EventHandler(this.check_caesar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 377);
            this.Controls.Add(this.check_caesar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thucthi_caesar);
            this.Controls.Add(this.key_caesar);
            this.Controls.Add(this.output_caesar);
            this.Controls.Add(this.input_caesar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_caesar;
        private System.Windows.Forms.TextBox output_caesar;
        private System.Windows.Forms.TextBox key_caesar;
        private System.Windows.Forms.ComboBox thucthi_caesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button check_caesar;
    }
}

