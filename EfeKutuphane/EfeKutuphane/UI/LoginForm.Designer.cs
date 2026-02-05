namespace EfeKutuphane
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtKullaniciAd = new TextBox();
            txtSifre = new TextBox();
            lblKullaniciAd = new Label();
            lblSifre = new Label();
            btnGiris = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(211, 279);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(168, 27);
            txtKullaniciAd.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(211, 366);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(168, 27);
            txtSifre.TabIndex = 1;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.BackColor = Color.Transparent;
            lblKullaniciAd.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKullaniciAd.ForeColor = Color.Sienna;
            lblKullaniciAd.Location = new Point(213, 235);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(168, 32);
            lblKullaniciAd.TabIndex = 2;
            lblKullaniciAd.Text = "Kullanıcı Adı";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.Transparent;
            lblSifre.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSifre.ForeColor = Color.Sienna;
            lblSifre.Location = new Point(263, 322);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(70, 32);
            lblSifre.TabIndex = 3;
            lblSifre.Text = "Şifre";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Sienna;
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.ForeColor = Color.AntiqueWhite;
            btnGiris.Location = new Point(211, 438);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(170, 53);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(100, -90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 419);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(600, 573);
            Controls.Add(btnGiris);
            Controls.Add(lblSifre);
            Controls.Add(lblKullaniciAd);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAd);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKullaniciAd;
        private TextBox txtSifre;
        private Label lblKullaniciAd;
        private Label lblSifre;
        private Button btnGiris;
        private PictureBox pictureBox1;
    }
}