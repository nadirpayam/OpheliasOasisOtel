
namespace OpheliasOasisOtel
{
    partial class CalisanGiris
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
            System.Windows.Forms.LinkLabel linkLabelSifremiUnuttum;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanGiris));
            this.buttonCikis = new System.Windows.Forms.Button();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.buttonAnasayfa = new System.Windows.Forms.Button();
            this.checkBoxGoster = new System.Windows.Forms.CheckBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKulAd = new System.Windows.Forms.TextBox();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKulAd = new System.Windows.Forms.Label();
            this.labelMusteriGiris = new System.Windows.Forms.Label();
            linkLabelSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelSifremiUnuttum
            // 
            linkLabelSifremiUnuttum.BackColor = System.Drawing.Color.Transparent;
            linkLabelSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            linkLabelSifremiUnuttum.ForeColor = System.Drawing.Color.DarkBlue;
            linkLabelSifremiUnuttum.LinkColor = System.Drawing.Color.White;
            linkLabelSifremiUnuttum.Location = new System.Drawing.Point(466, 484);
            linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            linkLabelSifremiUnuttum.Size = new System.Drawing.Size(193, 23);
            linkLabelSifremiUnuttum.TabIndex = 77;
            linkLabelSifremiUnuttum.TabStop = true;
            linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            linkLabelSifremiUnuttum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(925, 24);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 78;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGirisYap.BackgroundImage")));
            this.buttonGirisYap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonGirisYap.Location = new System.Drawing.Point(471, 393);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(197, 55);
            this.buttonGirisYap.TabIndex = 76;
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // buttonAnasayfa
            // 
            this.buttonAnasayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAnasayfa.BackgroundImage")));
            this.buttonAnasayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnasayfa.Location = new System.Drawing.Point(29, 541);
            this.buttonAnasayfa.Name = "buttonAnasayfa";
            this.buttonAnasayfa.Size = new System.Drawing.Size(90, 67);
            this.buttonAnasayfa.TabIndex = 75;
            this.buttonAnasayfa.UseVisualStyleBackColor = true;
            // 
            // checkBoxGoster
            // 
            this.checkBoxGoster.AutoSize = true;
            this.checkBoxGoster.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxGoster.ForeColor = System.Drawing.Color.White;
            this.checkBoxGoster.Location = new System.Drawing.Point(727, 291);
            this.checkBoxGoster.Name = "checkBoxGoster";
            this.checkBoxGoster.Size = new System.Drawing.Size(107, 33);
            this.checkBoxGoster.TabIndex = 74;
            this.checkBoxGoster.Text = "Göster";
            this.checkBoxGoster.UseVisualStyleBackColor = false;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSifre.Location = new System.Drawing.Point(471, 291);
            this.textBoxSifre.Multiline = true;
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(200, 40);
            this.textBoxSifre.TabIndex = 73;
            // 
            // textBoxKulAd
            // 
            this.textBoxKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKulAd.Location = new System.Drawing.Point(471, 206);
            this.textBoxKulAd.Multiline = true;
            this.textBoxKulAd.Name = "textBoxKulAd";
            this.textBoxKulAd.Size = new System.Drawing.Size(200, 40);
            this.textBoxKulAd.TabIndex = 72;
            // 
            // labelSifre
            // 
            this.labelSifre.BackColor = System.Drawing.Color.Transparent;
            this.labelSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.ForeColor = System.Drawing.Color.White;
            this.labelSifre.Location = new System.Drawing.Point(181, 293);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(252, 42);
            this.labelSifre.TabIndex = 71;
            this.labelSifre.Text = "Şifre:";
            this.labelSifre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelKulAd
            // 
            this.labelKulAd.BackColor = System.Drawing.Color.Transparent;
            this.labelKulAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKulAd.ForeColor = System.Drawing.Color.White;
            this.labelKulAd.Location = new System.Drawing.Point(181, 206);
            this.labelKulAd.Name = "labelKulAd";
            this.labelKulAd.Size = new System.Drawing.Size(252, 42);
            this.labelKulAd.TabIndex = 70;
            this.labelKulAd.Text = "Kullanıcı Adı:";
            this.labelKulAd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMusteriGiris
            // 
            this.labelMusteriGiris.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMusteriGiris.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMusteriGiris.ForeColor = System.Drawing.Color.White;
            this.labelMusteriGiris.Location = new System.Drawing.Point(229, 84);
            this.labelMusteriGiris.Name = "labelMusteriGiris";
            this.labelMusteriGiris.Size = new System.Drawing.Size(454, 71);
            this.labelMusteriGiris.TabIndex = 69;
            this.labelMusteriGiris.Text = "CALISAN GIRIS";
            this.labelMusteriGiris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalisanGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1038, 685);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(linkLabelSifremiUnuttum);
            this.Controls.Add(this.buttonGirisYap);
            this.Controls.Add(this.buttonAnasayfa);
            this.Controls.Add(this.checkBoxGoster);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKulAd);
            this.Controls.Add(this.labelSifre);
            this.Controls.Add(this.labelKulAd);
            this.Controls.Add(this.labelMusteriGiris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalisanGiris";
            this.Text = "CalisanGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Button buttonAnasayfa;
        private System.Windows.Forms.CheckBox checkBoxGoster;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKulAd;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKulAd;
        private System.Windows.Forms.Label labelMusteriGiris;
    }
}