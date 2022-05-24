
namespace OpheliasOasisOtel
{
    partial class BeklenenDolulukRaporu
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
            this.textBoxKayit = new System.Windows.Forms.TextBox();
            this.labelKayit = new System.Windows.Forms.Label();
            this.labeloran = new System.Windows.Forms.Label();
            this.textBoxoran = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoluluk)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdoluluk
            // 
            this.dataGridViewdoluluk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdoluluk.Location = new System.Drawing.Point(63, 48);
            this.dataGridViewdoluluk.Name = "dataGridViewdoluluk";
            this.dataGridViewdoluluk.RowHeadersWidth = 51;
            this.dataGridViewdoluluk.RowTemplate.Height = 24;
            this.dataGridViewdoluluk.Size = new System.Drawing.Size(921, 214);
            this.dataGridViewdoluluk.TabIndex = 0;
            // 
            // textBoxKayit
            // 
            this.textBoxKayit.Location = new System.Drawing.Point(300, 307);
            this.textBoxKayit.Multiline = true;
            this.textBoxKayit.Name = "textBoxKayit";
            this.textBoxKayit.Size = new System.Drawing.Size(230, 36);
            this.textBoxKayit.TabIndex = 1;
            // 
            // labelKayit
            // 
            this.labelKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKayit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKayit.Location = new System.Drawing.Point(58, 307);
            this.labelKayit.Name = "labelKayit";
            this.labelKayit.Size = new System.Drawing.Size(168, 36);
            this.labelKayit.TabIndex = 2;
            this.labelKayit.Text = "Kayit Sayisi:";
            // 
            // labeloran
            // 
            this.labeloran.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeloran.ForeColor = System.Drawing.SystemColors.Control;
            this.labeloran.Location = new System.Drawing.Point(58, 404);
            this.labeloran.Name = "labeloran";
            this.labeloran.Size = new System.Drawing.Size(180, 34);
            this.labeloran.TabIndex = 3;
            this.labeloran.Text = "Doluluk Oranı:";
            // 
            // textBoxoran
            // 
            this.textBoxoran.Location = new System.Drawing.Point(300, 401);
            this.textBoxoran.Multiline = true;
            this.textBoxoran.Name = "textBoxoran";
            this.textBoxoran.Size = new System.Drawing.Size(230, 37);
            this.textBoxoran.TabIndex = 4;
            this.textBoxoran.TextChanged += new System.EventHandler(this.textBoxoran_TextChanged);
            // 
            // BeklenenDolulukRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 557);
            this.Controls.Add(this.textBoxoran);
            this.Controls.Add(this.labeloran);
            this.Controls.Add(this.labelKayit);
            this.Controls.Add(this.textBoxKayit);
            this.Controls.Add(this.dataGridViewdoluluk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BeklenenDolulukRaporu";
            this.Text = "BeklenenDolulukRaporu";
            this.Load += new System.EventHandler(this.BeklenenDolulukRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoluluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdoluluk;
        private System.Windows.Forms.TextBox textBoxKayit;
        private System.Windows.Forms.Label labelKayit;
        private System.Windows.Forms.Label labeloran;
        private System.Windows.Forms.TextBox textBoxoran;
    }
}