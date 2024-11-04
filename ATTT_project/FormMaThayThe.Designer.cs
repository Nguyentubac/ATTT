namespace Mathaythe
{
    partial class FormMaThayThe
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
            this.Key_thaythe = new System.Windows.Forms.TextBox();
            this.ketqua_thaythe = new System.Windows.Forms.TextBox();
            this.thongdiep_thaythe = new System.Windows.Forms.TextBox();
            this.gen_thaythe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thucthi_thaythe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Key_thaythe
            // 
            this.Key_thaythe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Key_thaythe.Location = new System.Drawing.Point(39, 69);
            this.Key_thaythe.Name = "Key_thaythe";
            this.Key_thaythe.Size = new System.Drawing.Size(514, 31);
            this.Key_thaythe.TabIndex = 0;
            // 
            // ketqua_thaythe
            // 
            this.ketqua_thaythe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketqua_thaythe.Location = new System.Drawing.Point(825, 69);
            this.ketqua_thaythe.Name = "ketqua_thaythe";
            this.ketqua_thaythe.Size = new System.Drawing.Size(326, 31);
            this.ketqua_thaythe.TabIndex = 1;
            // 
            // thongdiep_thaythe
            // 
            this.thongdiep_thaythe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongdiep_thaythe.Location = new System.Drawing.Point(39, 171);
            this.thongdiep_thaythe.Name = "thongdiep_thaythe";
            this.thongdiep_thaythe.Size = new System.Drawing.Size(399, 31);
            this.thongdiep_thaythe.TabIndex = 2;
            // 
            // gen_thaythe
            // 
            this.gen_thaythe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen_thaythe.Location = new System.Drawing.Point(597, 53);
            this.gen_thaythe.Name = "gen_thaythe";
            this.gen_thaythe.Size = new System.Drawing.Size(185, 47);
            this.gen_thaythe.TabIndex = 4;
            this.gen_thaythe.Text = "Ngẫu nhiên";
            this.gen_thaythe.UseVisualStyleBackColor = true;
            this.gen_thaythe.Click += new System.EventHandler(this.gen_thaythe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(531, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thực thi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập chuỗi key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập thông điệp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(913, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả";
            // 
            // thucthi_thaythe
            // 
            this.thucthi_thaythe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thucthi_thaythe.FormattingEnabled = true;
            this.thucthi_thaythe.Items.AddRange(new object[] {
            "Mã hóa",
            "Giải mã"});
            this.thucthi_thaythe.Location = new System.Drawing.Point(39, 251);
            this.thucthi_thaythe.Name = "thucthi_thaythe";
            this.thucthi_thaythe.Size = new System.Drawing.Size(169, 33);
            this.thucthi_thaythe.TabIndex = 10;
            this.thucthi_thaythe.Text = "Mã Hóa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 434);
            this.Controls.Add(this.thucthi_thaythe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gen_thaythe);
            this.Controls.Add(this.thongdiep_thaythe);
            this.Controls.Add(this.ketqua_thaythe);
            this.Controls.Add(this.Key_thaythe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Key_thaythe;
        private System.Windows.Forms.TextBox ketqua_thaythe;
        private System.Windows.Forms.TextBox thongdiep_thaythe;
        private System.Windows.Forms.Button gen_thaythe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox thucthi_thaythe;
    }
}

