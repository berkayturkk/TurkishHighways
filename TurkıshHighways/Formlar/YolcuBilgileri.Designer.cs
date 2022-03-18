
namespace TurkıshHighways.Formlar
{
    partial class YolcuBilgileri
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtKimlik = new System.Windows.Forms.TextBox();
            this.lblKimlik = new System.Windows.Forms.Label();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.txtPasaport = new System.Windows.Forms.TextBox();
            this.lblPasaport = new System.Windows.Forms.Label();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.rdbTcVatandasıDegilim = new System.Windows.Forms.RadioButton();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.grpYolcuBilgileri = new System.Windows.Forms.GroupBox();
            this.btnYolcuKaydet = new System.Windows.Forms.Button();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.grpYolcuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(14, 52);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(260, 20);
            this.txtAd.TabIndex = 6;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(11, 36);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(14, 100);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(260, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(11, 84);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyad";
            // 
            // txtKimlik
            // 
            this.txtKimlik.Location = new System.Drawing.Point(14, 154);
            this.txtKimlik.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKimlik.Name = "txtKimlik";
            this.txtKimlik.Size = new System.Drawing.Size(260, 20);
            this.txtKimlik.TabIndex = 10;
            // 
            // lblKimlik
            // 
            this.lblKimlik.AutoSize = true;
            this.lblKimlik.Location = new System.Drawing.Point(11, 137);
            this.lblKimlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKimlik.Name = "lblKimlik";
            this.lblKimlik.Size = new System.Drawing.Size(104, 13);
            this.lblKimlik.TabIndex = 9;
            this.lblKimlik.Text = "T.C. Kimlik Numarası";
            this.lblKimlik.Click += new System.EventHandler(this.lblKimlik_Click);
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Location = new System.Drawing.Point(11, 183);
            this.lblUyruk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(35, 13);
            this.lblUyruk.TabIndex = 11;
            this.lblUyruk.Text = "Uyruk";
            // 
            // txtPasaport
            // 
            this.txtPasaport.Enabled = false;
            this.txtPasaport.Location = new System.Drawing.Point(14, 249);
            this.txtPasaport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPasaport.Name = "txtPasaport";
            this.txtPasaport.Size = new System.Drawing.Size(260, 20);
            this.txtPasaport.TabIndex = 14;
            // 
            // lblPasaport
            // 
            this.lblPasaport.AutoSize = true;
            this.lblPasaport.Location = new System.Drawing.Point(11, 233);
            this.lblPasaport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasaport.Name = "lblPasaport";
            this.lblPasaport.Size = new System.Drawing.Size(96, 13);
            this.lblPasaport.TabIndex = 13;
            this.lblPasaport.Text = "Pasaport Numarası";
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.Enabled = false;
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Location = new System.Drawing.Point(14, 199);
            this.cmbUyruk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(260, 21);
            this.cmbUyruk.TabIndex = 15;
            // 
            // rdbTcVatandasıDegilim
            // 
            this.rdbTcVatandasıDegilim.AutoSize = true;
            this.rdbTcVatandasıDegilim.Location = new System.Drawing.Point(143, 136);
            this.rdbTcVatandasıDegilim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbTcVatandasıDegilim.Name = "rdbTcVatandasıDegilim";
            this.rdbTcVatandasıDegilim.Size = new System.Drawing.Size(132, 17);
            this.rdbTcVatandasıDegilim.TabIndex = 16;
            this.rdbTcVatandasıDegilim.TabStop = true;
            this.rdbTcVatandasıDegilim.Text = "T.C. Vatandaşı Değilim";
            this.rdbTcVatandasıDegilim.UseVisualStyleBackColor = true;
            this.rdbTcVatandasıDegilim.CheckedChanged += new System.EventHandler(this.rdbTcVatandasıDegilim_CheckedChanged);
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(34, 36);
            this.lblKoltukNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(0, 13);
            this.lblKoltukNo.TabIndex = 17;
            // 
            // grpYolcuBilgileri
            // 
            this.grpYolcuBilgileri.Controls.Add(this.lblKoltukNo);
            this.grpYolcuBilgileri.Controls.Add(this.rdbTcVatandasıDegilim);
            this.grpYolcuBilgileri.Controls.Add(this.cmbUyruk);
            this.grpYolcuBilgileri.Controls.Add(this.lblPasaport);
            this.grpYolcuBilgileri.Controls.Add(this.txtPasaport);
            this.grpYolcuBilgileri.Controls.Add(this.lblUyruk);
            this.grpYolcuBilgileri.Controls.Add(this.lblKimlik);
            this.grpYolcuBilgileri.Controls.Add(this.txtKimlik);
            this.grpYolcuBilgileri.Controls.Add(this.lblSoyad);
            this.grpYolcuBilgileri.Controls.Add(this.txtSoyad);
            this.grpYolcuBilgileri.Controls.Add(this.lblAd);
            this.grpYolcuBilgileri.Controls.Add(this.txtAd);
            this.grpYolcuBilgileri.Location = new System.Drawing.Point(9, 10);
            this.grpYolcuBilgileri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpYolcuBilgileri.Name = "grpYolcuBilgileri";
            this.grpYolcuBilgileri.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpYolcuBilgileri.Size = new System.Drawing.Size(284, 283);
            this.grpYolcuBilgileri.TabIndex = 4;
            this.grpYolcuBilgileri.TabStop = false;
            this.grpYolcuBilgileri.Text = "Yolcu Bilgileri";
            // 
            // btnYolcuKaydet
            // 
            this.btnYolcuKaydet.Location = new System.Drawing.Point(22, 297);
            this.btnYolcuKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYolcuKaydet.Name = "btnYolcuKaydet";
            this.btnYolcuKaydet.Size = new System.Drawing.Size(114, 30);
            this.btnYolcuKaydet.TabIndex = 5;
            this.btnYolcuKaydet.Text = "Kaydet";
            this.btnYolcuKaydet.UseVisualStyleBackColor = true;
            this.btnYolcuKaydet.Click += new System.EventHandler(this.btnYolcuKaydet_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVazgec.Location = new System.Drawing.Point(167, 297);
            this.btnVazgec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(114, 30);
            this.btnVazgec.TabIndex = 6;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = true;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // YolcuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 338);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnYolcuKaydet);
            this.Controls.Add(this.grpYolcuBilgileri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YolcuBilgileri";
            this.Text = "YolcuBilgileri";
            this.Load += new System.EventHandler(this.YolcuBilgileri_Load);
            this.grpYolcuBilgileri.ResumeLayout(false);
            this.grpYolcuBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtKimlik;
        private System.Windows.Forms.Label lblKimlik;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.TextBox txtPasaport;
        private System.Windows.Forms.Label lblPasaport;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.RadioButton rdbTcVatandasıDegilim;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.GroupBox grpYolcuBilgileri;
        private System.Windows.Forms.Button btnYolcuKaydet;
        private System.Windows.Forms.Button btnVazgec;
    }
}