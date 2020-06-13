namespace Final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kul_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.grs_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.uye_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // kul_textbox
            // 
            this.kul_textbox.Location = new System.Drawing.Point(106, 231);
            this.kul_textbox.Name = "kul_textbox";
            this.kul_textbox.Size = new System.Drawing.Size(137, 26);
            this.kul_textbox.TabIndex = 2;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(106, 290);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.PasswordChar = '*';
            this.sifre_textbox.Size = new System.Drawing.Size(137, 26);
            this.sifre_textbox.TabIndex = 3;
            this.sifre_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sifre_textbox_KeyDown);
            // 
            // grs_btn
            // 
            this.grs_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.grs_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grs_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grs_btn.Location = new System.Drawing.Point(69, 362);
            this.grs_btn.Name = "grs_btn";
            this.grs_btn.Size = new System.Drawing.Size(227, 51);
            this.grs_btn.TabIndex = 4;
            this.grs_btn.Text = "Giriş Yap";
            this.grs_btn.UseVisualStyleBackColor = false;
            this.grs_btn.Click += new System.EventHandler(this.grs_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Arial", 34F);
            this.label3.Location = new System.Drawing.Point(45, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sahibinden";
            // 
            // uye_btn
            // 
            this.uye_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.uye_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uye_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uye_btn.Location = new System.Drawing.Point(113, 419);
            this.uye_btn.Name = "uye_btn";
            this.uye_btn.Size = new System.Drawing.Size(130, 51);
            this.uye_btn.TabIndex = 6;
            this.uye_btn.Text = "Üye Ol";
            this.uye_btn.UseVisualStyleBackColor = false;
            this.uye_btn.Click += new System.EventHandler(this.uye_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(108, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Üye Girişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 556);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uye_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grs_btn);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kul_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Kullanıcı Girişi - Sahibinden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kul_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.Button grs_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uye_btn;
        private System.Windows.Forms.Label label4;
    }
}

