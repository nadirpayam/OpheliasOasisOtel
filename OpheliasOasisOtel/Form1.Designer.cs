
namespace OpheliasOasisOtel
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.buttonKaydol = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonMusteriGiris = new System.Windows.Forms.Button();
            this.buttonCalisan = new System.Windows.Forms.Button();
            this.buttonYonetici = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonKaydol
            // 
            this.buttonKaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydol.Location = new System.Drawing.Point(275, 90);
            this.buttonKaydol.Name = "buttonKaydol";
            this.buttonKaydol.Size = new System.Drawing.Size(219, 68);
            this.buttonKaydol.TabIndex = 3;
            this.buttonKaydol.Text = "Kaydol";
            this.buttonKaydol.UseVisualStyleBackColor = true;
            this.buttonKaydol.Click += new System.EventHandler(this.buttonUyeOl_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(703, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 39;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // buttonMusteriGiris
            // 
            this.buttonMusteriGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusteriGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMusteriGiris.Location = new System.Drawing.Point(275, 184);
            this.buttonMusteriGiris.Name = "buttonMusteriGiris";
            this.buttonMusteriGiris.Size = new System.Drawing.Size(219, 68);
            this.buttonMusteriGiris.TabIndex = 40;
            this.buttonMusteriGiris.Text = "Müşteri Giriş";
            this.buttonMusteriGiris.UseVisualStyleBackColor = true;
            this.buttonMusteriGiris.Click += new System.EventHandler(this.buttonMusteriGiris_Click);
            // 
            // buttonCalisan
            // 
            this.buttonCalisan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCalisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCalisan.Location = new System.Drawing.Point(275, 277);
            this.buttonCalisan.Name = "buttonCalisan";
            this.buttonCalisan.Size = new System.Drawing.Size(219, 68);
            this.buttonCalisan.TabIndex = 41;
            this.buttonCalisan.Text = "Calisan Giriş";
            this.buttonCalisan.UseVisualStyleBackColor = true;
            this.buttonCalisan.Click += new System.EventHandler(this.buttonCalisan_Click);
            // 
            // buttonYonetici
            // 
            this.buttonYonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYonetici.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonYonetici.Location = new System.Drawing.Point(275, 366);
            this.buttonYonetici.Name = "buttonYonetici";
            this.buttonYonetici.Size = new System.Drawing.Size(219, 68);
            this.buttonYonetici.TabIndex = 43;
            this.buttonYonetici.Text = "Yönetici giriş";
            this.buttonYonetici.UseVisualStyleBackColor = true;
            this.buttonYonetici.Click += new System.EventHandler(this.buttonYonetici_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.buttonYonetici);
            this.Controls.Add(this.buttonCalisan);
            this.Controls.Add(this.buttonMusteriGiris);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonKaydol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Anasayfa";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonKaydol;
        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonMusteriGiris;
        private System.Windows.Forms.Button buttonCalisan;
        private System.Windows.Forms.Button buttonYonetici;
    }
}

