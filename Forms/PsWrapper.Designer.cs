using System;
using System.Collections.Generic;
using PStarsWrapper;
namespace PStarsWrapper.MisForms
{
    partial class PsWrapper
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.obtenerSizeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.capturarBtn = new System.Windows.Forms.Button();
            this.btnCapCartas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(455, 10);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(333, 407);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // resizeBtn
            // 
            this.resizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resizeBtn.Location = new System.Drawing.Point(13, 393);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(108, 23);
            this.resizeBtn.TabIndex = 2;
            this.resizeBtn.Text = "Redimensionar";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // obtenerSizeBtn
            // 
            this.obtenerSizeBtn.Location = new System.Drawing.Point(128, 393);
            this.obtenerSizeBtn.Name = "obtenerSizeBtn";
            this.obtenerSizeBtn.Size = new System.Drawing.Size(122, 23);
            this.obtenerSizeBtn.TabIndex = 3;
            this.obtenerSizeBtn.Text = "Obtener Tamaño";
            this.obtenerSizeBtn.UseVisualStyleBackColor = true;
            this.obtenerSizeBtn.Click += new System.EventHandler(this.obtenerSizeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // capturarBtn
            // 
            this.capturarBtn.Location = new System.Drawing.Point(13, 364);
            this.capturarBtn.Name = "capturarBtn";
            this.capturarBtn.Size = new System.Drawing.Size(75, 23);
            this.capturarBtn.TabIndex = 5;
            this.capturarBtn.Text = "Capturar";
            this.capturarBtn.UseVisualStyleBackColor = true;
            this.capturarBtn.Click += new System.EventHandler(this.capturarBtn_Click);
            // 
            // btnCapCartas
            // 
            this.btnCapCartas.Location = new System.Drawing.Point(95, 364);
            this.btnCapCartas.Name = "btnCapCartas";
            this.btnCapCartas.Size = new System.Drawing.Size(75, 23);
            this.btnCapCartas.TabIndex = 6;
            this.btnCapCartas.Text = "CapturarCartas";
            this.btnCapCartas.UseVisualStyleBackColor = true;
            this.btnCapCartas.Click += new System.EventHandler(this.btnCapCartas_Click);
            // 
            // PsWrapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCapCartas);
            this.Controls.Add(this.capturarBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obtenerSizeBtn);
            this.Controls.Add(this.resizeBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "PsWrapper";
            this.Text = "PsWrapper";
            this.Load += new System.EventHandler(this.PsWrapper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private void LLenarListBox()
        {
            foreach (IntPtr ventana in ListaVentanas)
            {
                listBox1.Items.Add(Util.ObtenerNombreVentana(ventana));
            }
            
        }
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.Button obtenerSizeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button capturarBtn;
        private System.Windows.Forms.Button btnCapCartas;
    }
}