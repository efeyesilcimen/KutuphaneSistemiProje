namespace EfeKutuphane
{
    partial class UyePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyePanel));
            dgvKitaplarim = new DataGridView();
            btnTalepEt = new Button();
            label1 = new Label();
            dgvKitapIste = new DataGridView();
            lblKitaplarim = new Label();
            lblKitapIste = new Label();
            lblKitapAraa = new Label();
            txtKitapAra = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapIste).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKitaplarim
            // 
            dgvKitaplarim.BackgroundColor = Color.DimGray;
            dgvKitaplarim.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitaplarim.Location = new Point(24, 110);
            dgvKitaplarim.Name = "dgvKitaplarim";
            dgvKitaplarim.RowHeadersVisible = false;
            dgvKitaplarim.RowHeadersWidth = 51;
            dgvKitaplarim.Size = new Size(291, 188);
            dgvKitaplarim.TabIndex = 0;
            // 
            // btnTalepEt
            // 
            btnTalepEt.BackColor = Color.DimGray;
            btnTalepEt.FlatStyle = FlatStyle.Popup;
            btnTalepEt.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnTalepEt.Location = new Point(287, 370);
            btnTalepEt.Name = "btnTalepEt";
            btnTalepEt.Size = new Size(226, 68);
            btnTalepEt.TabIndex = 2;
            btnTalepEt.Text = "Yeni Kitap Talebi Oluştur";
            btnTalepEt.UseVisualStyleBackColor = false;
            btnTalepEt.Click += btnTalepEt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(287, 43);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 3;
            label1.Text = "Hoş Geldin";
            // 
            // dgvKitapIste
            // 
            dgvKitapIste.BackgroundColor = Color.DimGray;
            dgvKitapIste.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKitapIste.Location = new Point(489, 110);
            dgvKitapIste.Name = "dgvKitapIste";
            dgvKitapIste.RowHeadersWidth = 51;
            dgvKitapIste.Size = new Size(300, 188);
            dgvKitapIste.TabIndex = 4;
            // 
            // lblKitaplarim
            // 
            lblKitaplarim.AutoSize = true;
            lblKitaplarim.BackColor = SystemColors.ControlDarkDark;
            lblKitaplarim.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKitaplarim.ForeColor = Color.Black;
            lblKitaplarim.Location = new Point(24, 84);
            lblKitaplarim.Name = "lblKitaplarim";
            lblKitaplarim.Size = new Size(101, 23);
            lblKitaplarim.TabIndex = 5;
            lblKitaplarim.Text = "Kitaplarım";
            // 
            // lblKitapIste
            // 
            lblKitapIste.AutoSize = true;
            lblKitapIste.BackColor = SystemColors.ControlDarkDark;
            lblKitapIste.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblKitapIste.ForeColor = Color.Black;
            lblKitapIste.Location = new Point(489, 84);
            lblKitapIste.Name = "lblKitapIste";
            lblKitapIste.Size = new Size(91, 23);
            lblKitapIste.TabIndex = 6;
            lblKitapIste.Text = "Kitap İste";
            // 
            // lblKitapAraa
            // 
            lblKitapAraa.AutoSize = true;
            lblKitapAraa.BackColor = Color.DimGray;
            lblKitapAraa.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblKitapAraa.Location = new Point(648, 83);
            lblKitapAraa.Name = "lblKitapAraa";
            lblKitapAraa.Size = new Size(40, 23);
            lblKitapAraa.TabIndex = 7;
            lblKitapAraa.Text = "Ara:";
            // 
            // txtKitapAra
            // 
            txtKitapAra.Location = new Point(694, 82);
            txtKitapAra.Name = "txtKitapAra";
            txtKitapAra.Size = new Size(95, 27);
            txtKitapAra.TabIndex = 8;
            txtKitapAra.TextChanged += txtKitapAra_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(274, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(264, 260);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // UyePanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(814, 467);
            Controls.Add(txtKitapAra);
            Controls.Add(lblKitapAraa);
            Controls.Add(lblKitapIste);
            Controls.Add(lblKitaplarim);
            Controls.Add(dgvKitapIste);
            Controls.Add(label1);
            Controls.Add(btnTalepEt);
            Controls.Add(dgvKitaplarim);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UyePanel";
            Text = "Üye Paneli";
            Load += UyePanel_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKitaplarim).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKitapIste).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKitaplarim;
        private Button btnTalepEt;
        private Label label1;
        private DataGridView dgvKitapIste;
        private Label lblKitaplarim;
        private Label lblKitapIste;
        private Label lblKitapAraa;
        private TextBox txtKitapAra;
        private PictureBox pictureBox1;
    }
}