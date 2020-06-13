namespace Final
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ad_textbox = new System.Windows.Forms.TextBox();
            this.soyad_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.kul_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uye_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // ad_textbox
            // 
            this.ad_textbox.Location = new System.Drawing.Point(73, 142);
            this.ad_textbox.MaxLength = 30;
            this.ad_textbox.Name = "ad_textbox";
            this.ad_textbox.Size = new System.Drawing.Size(146, 26);
            this.ad_textbox.TabIndex = 4;
            this.ad_textbox.Leave += new System.EventHandler(this.ad_textbox_Leave);
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(73, 204);
            this.soyad_textbox.MaxLength = 30;
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(146, 26);
            this.soyad_textbox.TabIndex = 5;
            this.soyad_textbox.Leave += new System.EventHandler(this.soyad_textbox_Leave);
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(73, 388);
            this.sifre_textbox.MaxLength = 20;
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.PasswordChar = '*';
            this.sifre_textbox.Size = new System.Drawing.Size(146, 26);
            this.sifre_textbox.TabIndex = 6;
            // 
            // kul_textbox
            // 
            this.kul_textbox.Location = new System.Drawing.Point(73, 264);
            this.kul_textbox.MaxLength = 16;
            this.kul_textbox.Name = "kul_textbox";
            this.kul_textbox.Size = new System.Drawing.Size(146, 26);
            this.kul_textbox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial", 34F);
            this.label5.Location = new System.Drawing.Point(30, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 52);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sahibinden";
            // 
            // uye_btn
            // 
            this.uye_btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.uye_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.uye_btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uye_btn.Location = new System.Drawing.Point(73, 471);
            this.uye_btn.Name = "uye_btn";
            this.uye_btn.Size = new System.Drawing.Size(146, 51);
            this.uye_btn.TabIndex = 9;
            this.uye_btn.Text = "Üye Ol";
            this.uye_btn.UseVisualStyleBackColor = false;
            this.uye_btn.Click += new System.EventHandler(this.uye_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Üye Kayıt";
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(73, 325);
            this.tel_textbox.MaxLength = 11;
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(146, 26);
            this.tel_textbox.TabIndex = 12;
            this.tel_textbox.Leave += new System.EventHandler(this.tel_textbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Telefon Numarası";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 561);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uye_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kul_textbox);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.soyad_textbox);
            this.Controls.Add(this.ad_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Üye Kayıt - Sahibinden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ad_textbox;
        private System.Windows.Forms.TextBox soyad_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox kul_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uye_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.Label label7;
    }
}