
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
            this.textBoxgelir.Location = new System.Drawing.Point(271, 82);
            this.textBoxgelir.Multiline = true;
            this.textBoxgelir.Name = "textBoxgelir";
            this.textBoxgelir.Size = new System.Drawing.Size(230, 22);
            this.textBoxgelir.TabIndex = 9;
            // 
            // labelgelir
            // 
            this.labelgelir.Location = new System.Drawing.Point(87, 81);
            this.labelgelir.Name = "labelgelir";
            this.labelgelir.Size = new System.Drawing.Size(146, 23);
            this.labelgelir.TabIndex = 8;
            this.labelgelir.Text = "Beklenen Gelir:";
            // 
            // textBoxortgelir
            // 
            this.textBoxortgelir.Location = new System.Drawing.Point(271, 144);
            this.textBoxortgelir.Multiline = true;
            this.textBoxortgelir.Name = "textBoxortgelir";
            this.textBoxortgelir.Size = new System.Drawing.Size(230, 22);
            this.textBoxortgelir.TabIndex = 11;
            this.textBoxortgelir.TextChanged += new System.EventHandler(this.textBoxortgelir_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(87, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ortalama gelir:";
            // 
            // buttonYazdir
            // 
            this.buttonYazdir.Location = new System.Drawing.Point(198, 244);
            this.buttonYazdir.Name = "buttonYazdir";
            this.buttonYazdir.Size = new System.Drawing.Size(206, 154);
            this.buttonYazdir.TabIndex = 12;
            this.buttonYazdir.Text = "Çıktı Al";
            this.buttonYazdir.UseVisualStyleBackColor = true;
            this.buttonYazdir.Click += new System.EventHandler(this.buttonYazdir_Click);
            // 
            // OdaGelirRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(636, 475);
            this.Controls.Add(this.buttonYazdir);
            this.Controls.Add(this.textBoxortgelir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxgelir);
            this.Controls.Add(this.labelgelir);
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