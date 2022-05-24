
namespace OpheliasOasisOtel
{
    partial class RezarvasyonAnasayfa
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
            this.buttonCikis = new System.Windows.Forms.Button();
            this.labelRezAnasayfa = new System.Windows.Forms.Label();
            this.labelistek = new System.Windows.Forms.Label();
            this.comboBoxRezler = new System.Windows.Forms.ComboBox();
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.labelGunluk = new System.Windows.Forms.Label();
            this.labelOdataban = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelTutar = new System.Windows.Forms.Label();
            this.textBoxKredi = new System.Windows.Forms.TextBox();
            this.labelKredi = new System.Windows.Forms.Label();
            this.labelAyrilisTarih = new System.Windows.Forms.Label();
            this.labelGelisTarih = new System.Windows.Forms.Label();
            this.dateTimePickerAyrilis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGelis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRez = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(970, 9);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 76;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // labelRezAnasayfa
            // 
            this.labelRezAnasayfa.BackColor = System.Drawing.Color.Transparent;
            this.labelRezAnasayfa.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRezAnasayfa.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRezAnasayfa.Location = new System.Drawing.Point(36, 18);
            this.labelRezAnasayfa.Name = "labelRezAnasayfa";
            this.labelRezAnasayfa.Size = new System.Drawing.Size(709, 71);
            this.labelRezAnasayfa.TabIndex = 77;
            this.labelRezAnasayfa.Text = "REZERVASYON ANASAYFA";
            this.labelRezAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelistek
            // 
            this.labelistek.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelistek.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelistek.ForeColor = System.Drawing.SystemColors.Control;
            this.labelistek.Location = new System.Drawing.Point(51, 121);
            this.labelistek.Name = "labelistek";
            this.labelistek.Size = new System.Drawing.Size(357, 33);
            this.labelistek.TabIndex = 78;
            this.labelistek.Text = "Rezervasyon tipini seçiniz";
            // 
            // comboBoxRezler
            // 
            this.comboBoxRezler.FormattingEnabled = true;
            this.comboBoxRezler.Items.AddRange(new object[] {
            "Ön Ödemeli Rezarvasyon",
            "60 Gün Önceden Rezarvasyon",
            "Standart(Klasik) Rezarvasyon",
            "Teşvik Rezarvasyonları"});
            this.comboBoxRezler.Location = new System.Drawing.Point(414, 121);
            this.comboBoxRezler.Name = "comboBoxRezler";
            this.comboBoxRezler.Size = new System.Drawing.Size(252, 24);
            this.comboBoxRezler.TabIndex = 84;
            this.comboBoxRezler.SelectedIndexChanged += new System.EventHandler(this.comboBoxRezler_SelectedIndexChanged);
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRezYap.Location = new System.Drawing.Point(578, 517);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(223, 58);
            this.buttonRezYap.TabIndex = 97;
            this.buttonRezYap.Text = "Rezarvasyon Oluştur";
            this.buttonRezYap.UseVisualStyleBackColor = false;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOnayla.Location = new System.Drawing.Point(66, 438);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(224, 60);
            this.buttonOnayla.TabIndex = 96;
            this.buttonOnayla.Text = "Hesabı Gör";
            this.buttonOnayla.UseVisualStyleBackColor = false;
            this.buttonOnayla.Click += new System.EventHandler(this.buttonOnayla_Click);
            // 
            // labelGunluk
            // 
            this.labelGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGunluk.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGunluk.Location = new System.Drawing.Point(334, 175);
            this.labelGunluk.Name = "labelGunluk";
            this.labelGunluk.Size = new System.Drawing.Size(140, 39);
            this.labelGunluk.TabIndex = 95;
            this.labelGunluk.Text = "0";
            // 
            // labelOdataban
            // 
            this.labelOdataban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOdataban.ForeColor = System.Drawing.SystemColors.Control;
            this.labelOdataban.Location = new System.Drawing.Point(51, 175);
            this.labelOdataban.Name = "labelOdataban";
            this.labelOdataban.Size = new System.Drawing.Size(269, 39);
            this.labelOdataban.TabIndex = 94;
            this.labelOdataban.Text = "Odanın günlük fiyatı: ";
            // 
            // labelFiyat
            // 
            this.labelFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiyat.ForeColor = System.Drawing.SystemColors.Control;
            this.labelFiyat.Location = new System.Drawing.Point(606, 438);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(118, 41);
            this.labelFiyat.TabIndex = 93;
            this.labelFiyat.Text = "0";
            // 
            // labelTutar
            // 
            this.labelTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTutar.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTutar.Location = new System.Drawing.Point(334, 438);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(245, 44);
            this.labelTutar.TabIndex = 92;
            this.labelTutar.Text = "Ödeyeceğiniz Tutar:";
            // 
            // textBoxKredi
            // 
            this.textBoxKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKredi.Location = new System.Drawing.Point(549, 350);
            this.textBoxKredi.Multiline = true;
            this.textBoxKredi.Name = "textBoxKredi";
            this.textBoxKredi.Size = new System.Drawing.Size(252, 38);
            this.textBoxKredi.TabIndex = 91;
            // 
            // labelKredi
            // 
            this.labelKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKredi.ForeColor = System.Drawing.SystemColors.Control;
            this.labelKredi.Location = new System.Drawing.Point(51, 364);
            this.labelKredi.Name = "labelKredi";
            this.labelKredi.Size = new System.Drawing.Size(423, 36);
            this.labelKredi.TabIndex = 90;
            this.labelKredi.Text = "Lütfen kredi kartı numaranızı girin:";
            // 
            // labelAyrilisTarih
            // 
            this.labelAyrilisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAyrilisTarih.ForeColor = System.Drawing.SystemColors.Control;
            this.labelAyrilisTarih.Location = new System.Drawing.Point(51, 292);
            this.labelAyrilisTarih.Name = "labelAyrilisTarih";
            this.labelAyrilisTarih.Size = new System.Drawing.Size(473, 33);
            this.labelAyrilisTarih.TabIndex = 89;
            this.labelAyrilisTarih.Text = "Lütfen çıkış yapmak istediğiniz tarihi seçin:";
            // 
            // labelGelisTarih
            // 
            this.labelGelisTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGelisTarih.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGelisTarih.Location = new System.Drawing.Point(51, 227);
            this.labelGelisTarih.Name = "labelGelisTarih";
            this.labelGelisTarih.Size = new System.Drawing.Size(473, 35);
            this.labelGelisTarih.TabIndex = 88;
            this.labelGelisTarih.Text = "Lütfen giriş yapmak istediğiniz tarihi seçin:";
            // 
            // dateTimePickerAyrilis
            // 
            this.dateTimePickerAyrilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAyrilis.Location = new System.Drawing.Point(549, 290);
            this.dateTimePickerAyrilis.Name = "dateTimePickerAyrilis";
            this.dateTimePickerAyrilis.Size = new System.Drawing.Size(252, 22);
            this.dateTimePickerAyrilis.TabIndex = 87;
            // 
            // dateTimePickerGelis
            // 
            this.dateTimePickerGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGelis.Location = new System.Drawing.Point(548, 227);
            this.dateTimePickerGelis.Name = "dateTimePickerGelis";
            this.dateTimePickerGelis.Size = new System.Drawing.Size(253, 22);
            this.dateTimePickerGelis.TabIndex = 86;
            // 
            // dateTimePickerRez
            // 
            this.dateTimePickerRez.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRez.Location = new System.Drawing.Point(45, 565);
            this.dateTimePickerRez.Name = "dateTimePickerRez";
            this.dateTimePickerRez.Size = new System.Drawing.Size(234, 22);
            this.dateTimePickerRez.TabIndex = 85;
            this.dateTimePickerRez.Visible = false;
            // 
            // RezarvasyonAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 623);
            this.Controls.Add(this.buttonRezYap);
            this.Controls.Add(this.buttonOnayla);
            this.Controls.Add(this.labelGunluk);
            this.Controls.Add(this.labelOdataban);
            this.Controls.Add(this.labelFiyat);
            this.Controls.Add(this.labelTutar);
            this.Controls.Add(this.textBoxKredi);
            this.Controls.Add(this.labelKredi);
            this.Controls.Add(this.labelAyrilisTarih);
            this.Controls.Add(this.labelGelisTarih);
            this.Controls.Add(this.dateTimePickerAyrilis);
            this.Controls.Add(this.dateTimePickerGelis);
            this.Controls.Add(this.dateTimePickerRez);
            this.Controls.Add(this.comboBoxRezler);
            this.Controls.Add(this.labelistek);
            this.Controls.Add(this.labelRezAnasayfa);
            this.Controls.Add(this.buttonCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezarvasyonAnasayfa";
            this.Text = "RezarvasyonAnasayfa";
            this.Load += new System.EventHandler(this.RezarvasyonAnasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelRezAnasayfa;
        private System.Windows.Forms.Label labelistek;
        private System.Windows.Forms.ComboBox comboBoxRezler;
        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.Label labelGunluk;
        private System.Windows.Forms.Label labelOdataban;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.TextBox textBoxKredi;
        private System.Windows.Forms.Label labelKredi;
        private System.Windows.Forms.Label labelAyrilisTarih;
        private System.Windows.Forms.Label labelGelisTarih;
        private System.Windows.Forms.DateTimePicker dateTimePickerAyrilis;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelis;
        private System.Windows.Forms.DateTimePicker dateTimePickerRez;
    }
}