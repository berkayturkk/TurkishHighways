
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeferListesi));
            this.lblGidisTarihi = new System.Windows.Forms.Label();
            this.lblSeferGidis = new System.Windows.Forms.Label();
            this.lblVarısYeri = new System.Windows.Forms.Label();
            this.lblSeferVarıs = new System.Windows.Forms.Label();
            this.lblKalkısYeri = new System.Windows.Forms.Label();
            this.lblSeferKalkıs = new System.Windows.Forms.Label();
            this.dataGridViewSefer = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGidisTarihi
            // 
            this.lblGidisTarihi.AutoSize = true;
            this.lblGidisTarihi.Location = new System.Drawing.Point(718, 37);
            this.lblGidisTarihi.Name = "lblGidisTarihi";
            this.lblGidisTarihi.Size = new System.Drawing.Size(46, 17);
            this.lblGidisTarihi.TabIndex = 17;
            this.lblGidisTarihi.Text = "label3";
            // 
            // lblSeferGidis
            // 
            this.lblSeferGidis.AutoSize = true;
            this.lblSeferGidis.Location = new System.Drawing.Point(620, 37);
            this.lblSeferGidis.Name = "lblSeferGidis";
            this.lblSeferGidis.Size = new System.Drawing.Size(92, 17);
            this.lblSeferGidis.TabIndex = 15;
            this.lblSeferGidis.Text = "Gidiş Tarihi  :";
            // 
            // lblVarısYeri
            // 
            this.lblVarısYeri.AutoSize = true;
            this.lblVarısYeri.Location = new System.Drawing.Point(522, 37);
            this.lblVarısYeri.Name = "lblVarısYeri";
            this.lblVarısYeri.Size = new System.Drawing.Size(46, 17);
            this.lblVarısYeri.TabIndex = 14;
            this.lblVarısYeri.Text = "label2";
            // 
            // lblSeferVarıs
            // 
            this.lblSeferVarıs.AutoSize = true;
            this.lblSeferVarıs.Location = new System.Drawing.Point(439, 37);
            this.lblSeferVarıs.Name = "lblSeferVarıs";
            this.lblSeferVarıs.Size = new System.Drawing.Size(77, 17);
            this.lblSeferVarıs.TabIndex = 13;
            this.lblSeferVarıs.Text = "Varış Yeri :";
            // 
            // lblKalkısYeri
            // 
            this.lblKalkısYeri.AutoSize = true;
            this.lblKalkısYeri.Location = new System.Drawing.Point(334, 37);
            this.lblKalkısYeri.Name = "lblKalkısYeri";
            this.lblKalkısYeri.Size = new System.Drawing.Size(46, 17);
            this.lblKalkısYeri.TabIndex = 12;
            this.lblKalkısYeri.Text = "label1";
            // 
            // lblSeferKalkıs
            // 
            this.lblSeferKalkıs.AutoSize = true;
            this.lblSeferKalkıs.Location = new System.Drawing.Point(246, 37);
            this.lblSeferKalkıs.Name = "lblSeferKalkıs";
            this.lblSeferKalkıs.Size = new System.Drawing.Size(82, 17);
            this.lblSeferKalkıs.TabIndex = 11;
            this.lblSeferKalkıs.Text = "Kalkış Yeri :";
            // 
            // dataGridViewSefer
            // 
            this.dataGridViewSefer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSefer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSefer.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewSefer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSefer.Name = "dataGridViewSefer";
            this.dataGridViewSefer.RowHeadersWidth = 51;
            this.dataGridViewSefer.RowTemplate.Height = 24;
            this.dataGridViewSefer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSefer.Size = new System.Drawing.Size(871, 529);
            this.dataGridViewSefer.TabIndex = 10;
            this.dataGridViewSefer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSefer_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // SeferListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 626);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGidisTarihi);
            this.Controls.Add(this.lblSeferGidis);
            this.Controls.Add(this.lblVarısYeri);
            this.Controls.Add(this.lblSeferVarıs);
            this.Controls.Add(this.lblKalkısYeri);
            this.Controls.Add(this.lblSeferKalkıs);
            this.Controls.Add(this.dataGridViewSefer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SeferListesi";
            this.Text = "SeferListesi";
            this.Load += new System.EventHandler(this.SeferListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSefer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        public System.Windows.Forms.DataGridView dataGridViewSefer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}