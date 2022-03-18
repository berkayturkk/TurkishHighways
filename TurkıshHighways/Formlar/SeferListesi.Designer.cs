
namespace TurkıshHighways.Formlar
{
    partial class SeferListesi
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
            this.lblGidisTarihi = new System.Windows.Forms.Label();
            this.lblSeferGidis = new System.Windows.Forms.Label();
            this.lblVarısYeri = new System.Windows.Forms.Label();
            this.lblSeferVarıs = new System.Windows.Forms.Label();
            this.lblKalkısYeri = new System.Windows.Forms.Label();
            this.lblSeferKalkıs = new System.Windows.Forms.Label();
            this.dataGridViewSefer = new System.Windows.Forms.DataGridView();
            this.btnSeferSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGidisTarihi
            // 
            this.lblGidisTarihi.AutoSize = true;
            this.lblGidisTarihi.Location = new System.Drawing.Point(561, 38);
            this.lblGidisTarihi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGidisTarihi.Name = "lblGidisTarihi";
            this.lblGidisTarihi.Size = new System.Drawing.Size(0, 13);
            this.lblGidisTarihi.TabIndex = 17;
            // 
            // lblSeferGidis
            // 
            this.lblSeferGidis.AutoSize = true;
            this.lblSeferGidis.Location = new System.Drawing.Point(495, 38);
            this.lblSeferGidis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeferGidis.Name = "lblSeferGidis";
            this.lblSeferGidis.Size = new System.Drawing.Size(68, 13);
            this.lblSeferGidis.TabIndex = 15;
            this.lblSeferGidis.Text = "Gidiş Tarihi  :";
            // 
            // lblVarısYeri
            // 
            this.lblVarısYeri.AutoSize = true;
            this.lblVarısYeri.Location = new System.Drawing.Point(414, 38);
            this.lblVarısYeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVarısYeri.Name = "lblVarısYeri";
            this.lblVarısYeri.Size = new System.Drawing.Size(0, 13);
            this.lblVarısYeri.TabIndex = 14;
            // 
            // lblSeferVarıs
            // 
            this.lblSeferVarıs.AutoSize = true;
            this.lblSeferVarıs.Location = new System.Drawing.Point(356, 38);
            this.lblSeferVarıs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeferVarıs.Name = "lblSeferVarıs";
            this.lblSeferVarıs.Size = new System.Drawing.Size(57, 13);
            this.lblSeferVarıs.TabIndex = 13;
            this.lblSeferVarıs.Text = "Varış Yeri :";
            // 
            // lblKalkısYeri
            // 
            this.lblKalkısYeri.AutoSize = true;
            this.lblKalkısYeri.Location = new System.Drawing.Point(273, 38);
            this.lblKalkısYeri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalkısYeri.Name = "lblKalkısYeri";
            this.lblKalkısYeri.Size = new System.Drawing.Size(0, 13);
            this.lblKalkısYeri.TabIndex = 12;
            // 
            // lblSeferKalkıs
            // 
            this.lblSeferKalkıs.AutoSize = true;
            this.lblSeferKalkıs.Location = new System.Drawing.Point(212, 38);
            this.lblSeferKalkıs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeferKalkıs.Name = "lblSeferKalkıs";
            this.lblSeferKalkıs.Size = new System.Drawing.Size(62, 13);
            this.lblSeferKalkıs.TabIndex = 11;
            this.lblSeferKalkıs.Text = "Kalkış Yeri :";
            // 
            // dataGridViewSefer
            // 
            this.dataGridViewSefer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSefer.Location = new System.Drawing.Point(70, 76);
            this.dataGridViewSefer.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSefer.Name = "dataGridViewSefer";
            this.dataGridViewSefer.RowHeadersWidth = 51;
            this.dataGridViewSefer.RowTemplate.Height = 24;
            this.dataGridViewSefer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSefer.Size = new System.Drawing.Size(653, 430);
            this.dataGridViewSefer.TabIndex = 10;
            // 
            // btnSeferSec
            // 
            this.btnSeferSec.Location = new System.Drawing.Point(308, 531);
            this.btnSeferSec.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeferSec.Name = "btnSeferSec";
            this.btnSeferSec.Size = new System.Drawing.Size(135, 28);
            this.btnSeferSec.TabIndex = 18;
            this.btnSeferSec.Text = "Sefer Seç ve Devam Et";
            this.btnSeferSec.UseVisualStyleBackColor = true;
            this.btnSeferSec.Click += new System.EventHandler(this.btnSeferSec_Click);
            // 
            // SeferListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 579);
            this.Controls.Add(this.btnSeferSec);
            this.Controls.Add(this.lblGidisTarihi);
            this.Controls.Add(this.lblSeferGidis);
            this.Controls.Add(this.lblVarısYeri);
            this.Controls.Add(this.lblSeferVarıs);
            this.Controls.Add(this.lblKalkısYeri);
            this.Controls.Add(this.lblSeferKalkıs);
            this.Controls.Add(this.dataGridViewSefer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeferListesi";
            this.Text = "SeferListesi";
            this.Load += new System.EventHandler(this.SeferListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblGidisTarihi;
        public System.Windows.Forms.Label lblSeferGidis;
        public System.Windows.Forms.Label lblVarısYeri;
        public System.Windows.Forms.Label lblSeferVarıs;
        public System.Windows.Forms.Label lblKalkısYeri;
        public System.Windows.Forms.Label lblSeferKalkıs;
        private System.Windows.Forms.DataGridView dataGridViewSefer;
        private System.Windows.Forms.Button btnSeferSec;
    }
}