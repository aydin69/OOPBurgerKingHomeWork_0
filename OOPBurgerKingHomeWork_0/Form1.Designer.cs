namespace OOPBurgerKingHomeWork_0
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
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMenuler = new System.Windows.Forms.ComboBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.rdbKucuk = new System.Windows.Forms.RadioButton();
            this.rdbOrta = new System.Windows.Forms.RadioButton();
            this.rdbBuyuk = new System.Windows.Forms.RadioButton();
            this.nmrAdet = new System.Windows.Forms.NumericUpDown();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.nmrMalzeme = new System.Windows.Forms.NumericUpDown();
            this.btnSiparis = new System.Windows.Forms.Button();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.btnMalzemeTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMalzeme)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(44, 38);
            this.txtIsim.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(132, 22);
            this.txtIsim.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(44, 398);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Malzemeler";
            // 
            // cmbMenuler
            // 
            this.cmbMenuler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMenuler.FormattingEnabled = true;
            this.cmbMenuler.Location = new System.Drawing.Point(44, 103);
            this.cmbMenuler.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMenuler.Name = "cmbMenuler";
            this.cmbMenuler.Size = new System.Drawing.Size(221, 24);
            this.cmbMenuler.TabIndex = 2;
            this.cmbMenuler.SelectedIndexChanged += new System.EventHandler(this.cmbMenuler_SelectedIndexChanged);
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(333, 38);
            this.lstSiparisler.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(936, 260);
            this.lstSiparisler.TabIndex = 3;
            // 
            // rdbKucuk
            // 
            this.rdbKucuk.AutoSize = true;
            this.rdbKucuk.Location = new System.Drawing.Point(44, 150);
            this.rdbKucuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdbKucuk.Name = "rdbKucuk";
            this.rdbKucuk.Size = new System.Drawing.Size(91, 20);
            this.rdbKucuk.TabIndex = 4;
            this.rdbKucuk.TabStop = true;
            this.rdbKucuk.Text = "Küçük Boy";
            this.rdbKucuk.UseVisualStyleBackColor = true;
            // 
            // rdbOrta
            // 
            this.rdbOrta.AutoSize = true;
            this.rdbOrta.Location = new System.Drawing.Point(44, 197);
            this.rdbOrta.Margin = new System.Windows.Forms.Padding(4);
            this.rdbOrta.Name = "rdbOrta";
            this.rdbOrta.Size = new System.Drawing.Size(80, 20);
            this.rdbOrta.TabIndex = 4;
            this.rdbOrta.TabStop = true;
            this.rdbOrta.Text = "Orta Boy";
            this.rdbOrta.UseVisualStyleBackColor = true;
            // 
            // rdbBuyuk
            // 
            this.rdbBuyuk.AutoSize = true;
            this.rdbBuyuk.Location = new System.Drawing.Point(44, 236);
            this.rdbBuyuk.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBuyuk.Name = "rdbBuyuk";
            this.rdbBuyuk.Size = new System.Drawing.Size(92, 20);
            this.rdbBuyuk.TabIndex = 4;
            this.rdbBuyuk.TabStop = true;
            this.rdbBuyuk.Text = "Büyük Boy";
            this.rdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // nmrAdet
            // 
            this.nmrAdet.Location = new System.Drawing.Point(217, 39);
            this.nmrAdet.Margin = new System.Windows.Forms.Padding(4);
            this.nmrAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrAdet.Name = "nmrAdet";
            this.nmrAdet.Size = new System.Drawing.Size(49, 22);
            this.nmrAdet.TabIndex = 6;
            this.nmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblBilgi
            // 
            this.lblBilgi.BackColor = System.Drawing.Color.LightGray;
            this.lblBilgi.Location = new System.Drawing.Point(44, 272);
            this.lblBilgi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(281, 85);
            this.lblBilgi.TabIndex = 7;
            this.lblBilgi.Text = "label2";
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.Location = new System.Drawing.Point(273, 463);
            this.btnMalzemeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(135, 28);
            this.btnMalzemeEkle.TabIndex = 8;
            this.btnMalzemeEkle.Text = "Malzeme Ekle";
            this.btnMalzemeEkle.UseVisualStyleBackColor = true;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(1024, 306);
            this.btnCiro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(100, 28);
            this.btnCiro.TabIndex = 8;
            this.btnCiro.Text = "Ciro";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(44, 430);
            this.cmbMalzeme.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(220, 24);
            this.cmbMalzeme.TabIndex = 2;
            this.cmbMalzeme.SelectedIndexChanged += new System.EventHandler(this.cmbMalzeme_SelectedIndexChanged);
            // 
            // nmrMalzeme
            // 
            this.nmrMalzeme.Location = new System.Drawing.Point(273, 430);
            this.nmrMalzeme.Margin = new System.Windows.Forms.Padding(4);
            this.nmrMalzeme.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrMalzeme.Name = "nmrMalzeme";
            this.nmrMalzeme.Size = new System.Drawing.Size(49, 22);
            this.nmrMalzeme.TabIndex = 6;
            this.nmrMalzeme.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnSiparis
            // 
            this.btnSiparis.Location = new System.Drawing.Point(460, 306);
            this.btnSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.btnSiparis.Name = "btnSiparis";
            this.btnSiparis.Size = new System.Drawing.Size(135, 28);
            this.btnSiparis.TabIndex = 8;
            this.btnSiparis.Text = "Spiariş Ekle";
            this.btnSiparis.UseVisualStyleBackColor = true;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.ItemHeight = 16;
            this.lstMalzemeler.Location = new System.Drawing.Point(44, 463);
            this.lstMalzemeler.Margin = new System.Windows.Forms.Padding(4);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(220, 148);
            this.lstMalzemeler.TabIndex = 9;
            this.lstMalzemeler.SelectedIndexChanged += new System.EventHandler(this.lstMalzemeler_SelectedIndexChanged);
            // 
            // btnMalzemeTemizle
            // 
            this.btnMalzemeTemizle.Location = new System.Drawing.Point(273, 498);
            this.btnMalzemeTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnMalzemeTemizle.Name = "btnMalzemeTemizle";
            this.btnMalzemeTemizle.Size = new System.Drawing.Size(135, 28);
            this.btnMalzemeTemizle.TabIndex = 8;
            this.btnMalzemeTemizle.Text = "Malzeme Temizle";
            this.btnMalzemeTemizle.UseVisualStyleBackColor = true;
            this.btnMalzemeTemizle.Click += new System.EventHandler(this.btnMalzemeTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1282, 620);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnSiparis);
            this.Controls.Add(this.btnMalzemeTemizle);
            this.Controls.Add(this.btnMalzemeEkle);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.nmrMalzeme);
            this.Controls.Add(this.nmrAdet);
            this.Controls.Add(this.rdbBuyuk);
            this.Controls.Add(this.rdbOrta);
            this.Controls.Add(this.rdbKucuk);
            this.Controls.Add(this.lstSiparisler);
            this.Controls.Add(this.cmbMalzeme);
            this.Controls.Add(this.cmbMenuler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIsim);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMalzeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMenuler;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.RadioButton rdbKucuk;
        private System.Windows.Forms.RadioButton rdbOrta;
        private System.Windows.Forms.RadioButton rdbBuyuk;
        private System.Windows.Forms.NumericUpDown nmrAdet;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.NumericUpDown nmrMalzeme;
        private System.Windows.Forms.Button btnSiparis;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Button btnMalzemeTemizle;
    }
}

