﻿
namespace OpheliasOasisOtel
{
    partial class Fatura
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
            this.dataGridViewdoluluk = new System.Windows.Forms.DataGridView();
            this.buttonYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoluluk)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdoluluk
            // 
            this.dataGridViewdoluluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoluluk.Location = new System.Drawing.Point(142, 45);
            this.dataGridViewdoluluk.Name = "dataGridViewdoluluk";
            this.dataGridViewdoluluk.RowHeadersWidth = 51;
            this.dataGridViewdoluluk.RowTemplate.Height = 24;
            this.dataGridViewdoluluk.Size = new System.Drawing.Size(586, 321);
            this.dataGridViewdoluluk.TabIndex = 2;
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(321, 392);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(206, 154);
            this.buttonYazdir.TabIndex = 3;
            this.buttonYazdir.Text = "Çıktı Al";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(915, 558);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.dataGridViewdoluluk);
            this.Name = "Fatura";
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.Fatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoluluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdoluluk;
        private System.Windows.Forms.Button buttonYazdir;
    }
}