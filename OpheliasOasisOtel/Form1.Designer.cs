
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
            this.SuspendLayout();
            // 
            // buttonKaydol
            // 
            this.buttonKaydol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKaydol.BackgroundImage")));
            this.buttonKaydol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKaydol.Location = new System.Drawing.Point(248, 205);
            this.buttonKaydol.Name = "buttonKaydol";
            this.buttonKaydol.Size = new System.Drawing.Size(219, 68);
            this.buttonKaydol.TabIndex = 3;
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
            this.buttonMusteriGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMusteriGiris.BackgroundImage")));
            this.buttonMusteriGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusteriGiris.Location = new System.Drawing.Point(248, 339);
            this.buttonMusteriGiris.Name = "buttonMusteriGiris";
            this.buttonMusteriGiris.Size = new System.Drawing.Size(219, 68);
            this.buttonMusteriGiris.TabIndex = 40;
            this.buttonMusteriGiris.UseVisualStyleBackColor = true;
            this.buttonMusteriGiris.Click += new System.EventHandler(this.buttonMusteriGiris_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 537);
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
    }
}

