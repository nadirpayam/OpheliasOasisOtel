
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
            this.dateTimePickertoday = new System.Windows.Forms.DateTimePicker();
            this.buttoniptalet = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.dateTimePickerdegisik = new System.Windows.Forms.DateTimePicker();
            this.buttonCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRezler
            // 
            this.dataGridViewRezler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezler.Location = new System.Drawing.Point(51, 51);
            this.dataGridViewRezler.Name = "dataGridViewRezler";
            this.dataGridViewRezler.RowHeadersWidth = 51;
            this.dataGridViewRezler.RowTemplate.Height = 24;
            this.dataGridViewRezler.Size = new System.Drawing.Size(636, 269);
            this.dataGridViewRezler.TabIndex = 0;
            // 
            // dateTimePickertoday
            // 
            this.dateTimePickertoday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickertoday.Location = new System.Drawing.Point(487, 12);
            this.dateTimePickertoday.Name = "dateTimePickertoday";
            this.dateTimePickertoday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickertoday.TabIndex = 1;
            this.dateTimePickertoday.Visible = false;
            // 
            // buttoniptalet
            // 
            this.buttoniptalet.BackColor = System.Drawing.Color.LightSalmon;
            this.buttoniptalet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttoniptalet.Location = new System.Drawing.Point(50, 354);
            this.buttoniptalet.Name = "buttoniptalet";
            this.buttoniptalet.Size = new System.Drawing.Size(218, 66);
            this.buttoniptalet.TabIndex = 2;
            this.buttoniptalet.Text = "Rezarvasyonu iptal et";
            this.buttoniptalet.UseVisualStyleBackColor = false;
            this.buttoniptalet.Click += new System.EventHandler(this.buttoniptalet_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.Location = new System.Drawing.Point(51, 453);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(217, 66);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Tarihi Değiştir";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // dateTimePickerdegisik
            // 
            this.dateTimePickerdegisik.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerdegisik.Location = new System.Drawing.Point(357, 473);
            this.dateTimePickerdegisik.Name = "dateTimePickerdegisik";
            this.dateTimePickerdegisik.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerdegisik.TabIndex = 4;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(784, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 69;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // Rezarvasyonlarim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(890, 580);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.dateTimePickerdegisik);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttoniptalet);
            this.Controls.Add(this.dateTimePickertoday);
            this.Controls.Add(this.dataGridViewRezler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rezarvasyonlarim";
            this.Text = "Rezarvasyonlarim";
            this.Load += new System.EventHandler(this.Rezarvasyonlarim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRezler;
        private System.Windows.Forms.DateTimePicker dateTimePickertoday;
        private System.Windows.Forms.Button buttoniptalet;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DateTimePicker dateTimePickerdegisik;
        private System.Windows.Forms.Button buttonCikis;
    }
}