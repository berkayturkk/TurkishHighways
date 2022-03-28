
namespace TurkıshHighways.Formlar
{
    partial class cvv2Nedir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cvv2Nedir));
            this.lblCVV2Nedir = new System.Windows.Forms.Label();
            this.lblCVV2 = new System.Windows.Forms.Label();
            this.pbCVV2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCVV2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCVV2Nedir
            // 
            this.lblCVV2Nedir.AutoSize = true;
            this.lblCVV2Nedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCVV2Nedir.Location = new System.Drawing.Point(161, 21);
            this.lblCVV2Nedir.Name = "lblCVV2Nedir";
            this.lblCVV2Nedir.Size = new System.Drawing.Size(139, 25);
            this.lblCVV2Nedir.TabIndex = 5;
            this.lblCVV2Nedir.Text = "CVV2 Nedir?";
            // 
            // lblCVV2
            // 
            this.lblCVV2.AutoSize = true;
            this.lblCVV2.Location = new System.Drawing.Point(194, 324);
            this.lblCVV2.Name = "lblCVV2";
            this.lblCVV2.Size = new System.Drawing.Size(224, 17);
            this.lblCVV2.TabIndex = 4;
            this.lblCVV2.Text = "Kartınızın arkasındaki son 3 rakam";
            // 
            // pbCVV2
            // 
            this.pbCVV2.Image = ((System.Drawing.Image)(resources.GetObject("pbCVV2.Image")));
            this.pbCVV2.Location = new System.Drawing.Point(42, 79);
            this.pbCVV2.Name = "pbCVV2";
            this.pbCVV2.Size = new System.Drawing.Size(394, 239);
            this.pbCVV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCVV2.TabIndex = 3;
            this.pbCVV2.TabStop = false;
            // 
            // cvv2Nedir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 364);
            this.Controls.Add(this.lblCVV2Nedir);
            this.Controls.Add(this.lblCVV2);
            this.Controls.Add(this.pbCVV2);
            this.Name = "cvv2Nedir";
            this.Text = "cvv2Nedir";
            ((System.ComponentModel.ISupportInitialize)(this.pbCVV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCVV2Nedir;
        private System.Windows.Forms.Label lblCVV2;
        private System.Windows.Forms.PictureBox pbCVV2;
    }
}