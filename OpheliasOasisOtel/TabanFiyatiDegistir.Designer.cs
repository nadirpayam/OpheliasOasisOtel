
namespace OpheliasOasisOtel
{
    partial class TabanFiyatiDegistir
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
            this.dataGridViewoda = new System.Windows.Forms.DataGridView();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.textBoxfiyati = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoda)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewoda
            // 
            this.dataGridViewoda.AllowUserToAddRows = false;
            this.dataGridViewoda.AllowUserToDeleteRows = false;
            this.dataGridViewoda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewoda.Location = new System.Drawing.Point(63, 42);
            this.dataGridViewoda.Name = "dataGridViewoda";
            this.dataGridViewoda.ReadOnly = true;
            this.dataGridViewoda.RowHeadersWidth = 51;
            this.dataGridViewoda.RowTemplate.Height = 24;
            this.dataGridViewoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewoda.Size = new System.Drawing.Size(445, 232);
            this.dataGridViewoda.TabIndex = 13;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(384, 396);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(124, 74);
            this.buttonGuncelle.TabIndex = 16;
            this.buttonGuncelle.Text = "Taban Fiyatını Değiştir";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click_1);
            // 
            // textBoxfiyati
            // 
            this.textBoxfiyati.Location = new System.Drawing.Point(314, 338);
            this.textBoxfiyati.Name = "textBoxfiyati";
            this.textBoxfiyati.Size = new System.Drawing.Size(200, 22);
            this.textBoxfiyati.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Yeni Taban Fiyatını Gir:";
            // 
            // TabanFiyatiDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 512);
            this.Controls.Add(this.textBoxfiyati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.dataGridViewoda);
            this.Name = "TabanFiyatiDegistir";
            this.Text = "TabanFiyatiDegistir";
            this.Load += new System.EventHandler(this.TabanFiyatiDegistir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewoda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewoda;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.TextBox textBoxfiyati;
        private System.Windows.Forms.Label label3;
    }
}