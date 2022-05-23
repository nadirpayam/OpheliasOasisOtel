
namespace OpheliasOasisOtel
{
    partial class GunlukGelenlerRaporu
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
            this.dataGridViewdoluluk.Location = new System.Drawing.Point(44, 43);
            this.dataGridViewdoluluk.Name = "dataGridViewdoluluk";
            this.dataGridViewdoluluk.RowHeadersWidth = 51;
            this.dataGridViewdoluluk.RowTemplate.Height = 24;
            this.dataGridViewdoluluk.Size = new System.Drawing.Size(687, 375);
            this.dataGridViewdoluluk.TabIndex = 1;
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYazdir.Location = new System.Drawing.Point(525, 439);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(206, 72);
            this.buttonYazdir.TabIndex = 4;
            this.buttonYazdir.Text = "Çıktı Al";
            this.buttonYazdir.UseVisualStyleBackColor = false;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // GunlukGelenlerRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.dataGridViewdoluluk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GunlukGelenlerRaporu";
            this.Text = "GunlukGelenlerRaporu";
            this.Load += new System.EventHandler(this.GunlukGelenlerRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdoluluk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdoluluk;
        private System.Windows.Forms.Button buttonYazdir;
    }
}