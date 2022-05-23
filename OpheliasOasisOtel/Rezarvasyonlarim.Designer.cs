
namespace OpheliasOasisOtel
{
    partial class Rezarvasyonlarim
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
            this.dataGridViewRezler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezler
            // 
            this.dataGridViewRezler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezler.Location = new System.Drawing.Point(51, 68);
            this.dataGridViewRezler.Name = "dataGridViewRezler";
            this.dataGridViewRezler.RowHeadersWidth = 51;
            this.dataGridViewRezler.RowTemplate.Height = 24;
            this.dataGridViewRezler.Size = new System.Drawing.Size(636, 269);
            this.dataGridViewRezler.TabIndex = 0;
            // 
            // Rezarvasyonlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.dataGridViewRezler);
            this.Name = "Rezarvasyonlarim";
            this.Text = "Rezarvasyonlarim";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezler;
    }
}