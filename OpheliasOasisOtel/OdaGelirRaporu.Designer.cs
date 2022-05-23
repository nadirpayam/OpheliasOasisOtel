
namespace OpheliasOasisOtel
{
    partial class OdaGelirRaporu
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
            this.textBoxgelir = new System.Windows.Forms.TextBox();
            this.labelgelir = new System.Windows.Forms.Label();
            this.textBoxortgelir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxgelir
            // 
            this.textBoxgelir.Location = new System.Drawing.Point(308, 81);
            this.textBoxgelir.Multiline = true;
            this.textBoxgelir.Name = "textBoxgelir";
            this.textBoxgelir.Size = new System.Drawing.Size(235, 32);
            this.textBoxgelir.TabIndex = 9;
            // 
            // labelgelir
            // 
            this.labelgelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelgelir.ForeColor = System.Drawing.SystemColors.Control;
            this.labelgelir.Location = new System.Drawing.Point(64, 81);
            this.labelgelir.Name = "labelgelir";
            this.labelgelir.Size = new System.Drawing.Size(175, 37);
            this.labelgelir.TabIndex = 8;
            this.labelgelir.Text = "Beklenen Gelir:";
            // 
            // textBoxortgelir
            // 
            this.textBoxortgelir.Location = new System.Drawing.Point(308, 143);
            this.textBoxortgelir.Multiline = true;
            this.textBoxortgelir.Name = "textBoxortgelir";
            this.textBoxortgelir.Size = new System.Drawing.Size(235, 32);
            this.textBoxortgelir.TabIndex = 11;
            this.textBoxortgelir.TextChanged += new System.EventHandler(this.textBoxortgelir_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 42);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ortalama gelir:";
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYazdir.Location = new System.Drawing.Point(308, 233);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(235, 68);
            this.buttonYazdir.TabIndex = 12;
            this.buttonYazdir.Text = "Çıktı Al";
            this.buttonYazdir.UseVisualStyleBackColor = false;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // OdaGelirRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 502);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.textBoxortgelir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxgelir);
            this.Controls.Add(this.labelgelir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OdaGelirRaporu";
            this.Text = "OdaGelirRaporu";
            this.Load += new System.EventHandler(this.OdaGelirRaporu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxgelir;
        private System.Windows.Forms.Label labelgelir;
        private System.Windows.Forms.TextBox textBoxortgelir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonYazdir;
    }
}