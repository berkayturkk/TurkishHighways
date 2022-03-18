
namespace TurkıshHighways.Formlar
{
    partial class BiletSecimEkranı
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
            this.lblNereden = new System.Windows.Forms.Label();
            this.cmbNereden = new System.Windows.Forms.ComboBox();
            this.lblNereye = new System.Windows.Forms.Label();
            this.cmbNereye = new System.Windows.Forms.ComboBox();
            this.lblGidisTarihi = new System.Windows.Forms.Label();
            this.dtmpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSeferleriGöster = new System.Windows.Forms.Button();
            this.gpbBiletSecim = new System.Windows.Forms.GroupBox();
            this.gpbBiletSecim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNereden
            // 
            this.lblNereden.AutoSize = true;
            this.lblNereden.Location = new System.Drawing.Point(6, 33);
            this.lblNereden.Name = "lblNereden";
            this.lblNereden.Size = new System.Drawing.Size(63, 17);
            this.lblNereden.TabIndex = 2;
            this.lblNereden.Text = "Nereden";
            // 
            // cmbNereden
            // 
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Location = new System.Drawing.Point(122, 30);
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(220, 24);
            this.cmbNereden.TabIndex = 3;
            // 
            // lblNereye
            // 
            this.lblNereye.AutoSize = true;
            this.lblNereye.Location = new System.Drawing.Point(6, 73);
            this.lblNereye.Name = "lblNereye";
            this.lblNereye.Size = new System.Drawing.Size(54, 17);
            this.lblNereye.TabIndex = 4;
            this.lblNereye.Text = "Nereye";
            // 
            // cmbNereye
            // 
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Location = new System.Drawing.Point(122, 70);
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(220, 24);
            this.cmbNereye.TabIndex = 5;
            // 
            // lblGidisTarihi
            // 
            this.lblGidisTarihi.AutoSize = true;
            this.lblGidisTarihi.Location = new System.Drawing.Point(6, 118);
            this.lblGidisTarihi.Name = "lblGidisTarihi";
            this.lblGidisTarihi.Size = new System.Drawing.Size(80, 17);
            this.lblGidisTarihi.TabIndex = 6;
            this.lblGidisTarihi.Text = "Gidiş Tarihi";
            // 
            // dtmpGidisTarihi
            // 
            this.dtmpGidisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmpGidisTarihi.Location = new System.Drawing.Point(122, 113);
            this.dtmpGidisTarihi.Name = "dtmpGidisTarihi";
            this.dtmpGidisTarihi.Size = new System.Drawing.Size(220, 22);
            this.dtmpGidisTarihi.TabIndex = 8;
            // 
            // btnSeferleriGöster
            // 
            this.btnSeferleriGöster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeferleriGöster.Location = new System.Drawing.Point(122, 152);
            this.btnSeferleriGöster.Name = "btnSeferleriGöster";
            this.btnSeferleriGöster.Size = new System.Drawing.Size(220, 27);
            this.btnSeferleriGöster.TabIndex = 10;
            this.btnSeferleriGöster.Text = "Seferleri Göster";
            this.btnSeferleriGöster.UseVisualStyleBackColor = true;
            this.btnSeferleriGöster.Click += new System.EventHandler(this.btnSeferleriGöster_Click);
            // 
            // gpbBiletSecim
            // 
            this.gpbBiletSecim.Controls.Add(this.btnSeferleriGöster);
            this.gpbBiletSecim.Controls.Add(this.dtmpGidisTarihi);
            this.gpbBiletSecim.Controls.Add(this.lblGidisTarihi);
            this.gpbBiletSecim.Controls.Add(this.cmbNereye);
            this.gpbBiletSecim.Controls.Add(this.lblNereye);
            this.gpbBiletSecim.Controls.Add(this.cmbNereden);
            this.gpbBiletSecim.Controls.Add(this.lblNereden);
            this.gpbBiletSecim.Location = new System.Drawing.Point(14, 135);
            this.gpbBiletSecim.Name = "gpbBiletSecim";
            this.gpbBiletSecim.Size = new System.Drawing.Size(472, 187);
            this.gpbBiletSecim.TabIndex = 9;
            this.gpbBiletSecim.TabStop = false;
            this.gpbBiletSecim.Text = "Bilet Seçim Ekranı";
            // 
            // BiletSecimEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 327);
            this.Controls.Add(this.gpbBiletSecim);
            this.Name = "BiletSecimEkranı";
            this.Text = "BiletSecimEkranı";
            this.Load += new System.EventHandler(this.BiletSecimEkranı_Load);
            this.gpbBiletSecim.ResumeLayout(false);
            this.gpbBiletSecim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblNereden;
        public System.Windows.Forms.ComboBox cmbNereden;
        public System.Windows.Forms.Label lblNereye;
        public System.Windows.Forms.ComboBox cmbNereye;
        public System.Windows.Forms.Label lblGidisTarihi;
        public System.Windows.Forms.DateTimePicker dtmpGidisTarihi;
        private System.Windows.Forms.Button btnSeferleriGöster;
        private System.Windows.Forms.GroupBox gpbBiletSecim;
    }
}