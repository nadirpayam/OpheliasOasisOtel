
namespace OpheliasOasisOtel
{
    partial class TesvikRaporu
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
            this.dataGridViewKar = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYazdir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKar
            // 
            this.dataGridViewKar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKar.Location = new System.Drawing.Point(102, 39);
            this.dataGridViewKar.Name = "dataGridViewKar";
            this.dataGridViewKar.RowHeadersWidth = 51;
            this.dataGridViewKar.RowTemplate.Height = 24;
            this.dataGridViewKar.Size = new System.Drawing.Size(493, 150);
            this.dataGridViewKar.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 453);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Visible = false;
            // 
            // labelTarih
            // 
            this.labelTarih.Location = new System.Drawing.Point(99, 229);
            this.labelTarih.Name = "labelTarih";
            this.labelTarih.Size = new System.Drawing.Size(100, 23);
            this.labelTarih.TabIndex = 2;
            this.labelTarih.Text = "Tarih:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(153, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 23);
            this.label1.TabIndex = 3;
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYazdir.Location = new System.Drawing.Point(389, 338);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(206, 72);
            this.buttonYazdir.TabIndex = 5;
            this.buttonYazdir.Text = "Çıktı Al";
            this.buttonYazdir.UseVisualStyleBackColor = false;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // TesvikRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTarih);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridViewKar);
            this.Name = "TesvikRaporu";
            this.Text = "TesvikRaporu";
            this.Load += new System.EventHandler(this.TesvikRaporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYazdir;
    }
}