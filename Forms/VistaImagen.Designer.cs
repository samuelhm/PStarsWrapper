namespace PStarsWrapper.MisForms
{
    partial class VistaImagen
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
            this.cajaImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cajaImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaImagen
            // 
            this.cajaImagen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cajaImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cajaImagen.Location = new System.Drawing.Point(0, 0);
            this.cajaImagen.Name = "cajaImagen";
            this.cajaImagen.Size = new System.Drawing.Size(100, 100);
            this.cajaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.cajaImagen.TabIndex = 0;
            this.cajaImagen.TabStop = false;
            this.cajaImagen.Click += new System.EventHandler(this.cajaImagen_Click);
            // 
            // VistaImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(100, 100);
            this.Controls.Add(this.cajaImagen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VistaImagen";
            this.Text = "VistaImagen";
            ((System.ComponentModel.ISupportInitialize)(this.cajaImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cajaImagen;
    }
}