
namespace OpheliasOasisOtel
{
    partial class OnOdeme
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
            this.dateTimePickerRez = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGelis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAyrilis = new System.Windows.Forms.DateTimePicker();
            this.labelGelisTarih = new System.Windows.Forms.Label();
            this.labelAyrilisTarih = new System.Windows.Forms.Label();
            this.labelKredi = new System.Windows.Forms.Label();
            this.textBoxKredi = new System.Windows.Forms.TextBox();
            this.labelTutar = new System.Windows.Forms.Label();
            this.labelFiyat = new System.Windows.Forms.Label();
            this.labelOdataban = new System.Windows.Forms.Label();
            this.labelGunluk = new System.Windows.Forms.Label();
            this.buttonOnayla = new System.Windows.Forms.Button();
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerRez
            // 
            this.dateTimePickerRez.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerRez.Location = new System.Drawing.Point(735, 21);
            this.dateTimePickerRez.Name = "dateTimePickerRez";
            this.dateTimePickerRez.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRez.TabIndex = 0;
            this.dateTimePickerRez.Visible = false;
            // 
            // dateTimePickerGelis
            // 
            this.dateTimePickerGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGelis.Location = new System.Drawing.Point(330, 128);
            this.dateTimePickerGelis.Name = "dateTimePickerGelis";
            this.dateTimePickerGelis.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerGelis.TabIndex = 1;
            // 
            // dateTimePickerAyrilis
            // 
            this.dateTimePickerAyrilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAyrilis.Location = new System.Drawing.Point(330, 182);
            this.dateTimePickerAyrilis.Name = "dateTimePickerAyrilis";
            this.dateTimePickerAyrilis.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAyrilis.TabIndex = 2;
            // 
            // labelGelisTarih
            // 
            this.labelGelisTarih.Location = new System.Drawing.Point(29, 128);
            this.labelGelisTarih.Name = "labelGelisTarih";
            this.labelGelisTarih.Size = new System.Drawing.Size(286, 23);
            this.labelGelisTarih.TabIndex = 3;
            this.labelGelisTarih.Text = "Lütfen giriş yapmak istediğiniz tarihi seçin:";
            // 
            // labelAyrilisTarih
            // 
            this.labelAyrilisTarih.Location = new System.Drawing.Point(29, 182);
            this.labelAyrilisTarih.Name = "labelAyrilisTarih";
            this.labelAyrilisTarih.Size = new System.Drawing.Size(286, 23);
            this.labelAyrilisTarih.TabIndex = 4;
            this.labelAyrilisTarih.Text = "Lütfen çıkış yapmak istediğiniz tarihi seçin:";
            // 
            // labelKredi
            // 
            this.labelKredi.Location = new System.Drawing.Point(29, 265);
            this.labelKredi.Name = "labelKredi";
            this.labelKredi.Size = new System.Drawing.Size(286, 23);
            this.labelKredi.TabIndex = 5;
            this.labelKredi.Text = "Lütfen kredi kartı numaranızı girin:";
            // 
            // textBoxKredi
            // 
            this.textBoxKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKredi.Location = new System.Drawing.Point(333, 249);
            this.textBoxKredi.Multiline = true;
            this.textBoxKredi.Name = "textBoxKredi";
            this.textBoxKredi.Size = new System.Drawing.Size(197, 39);
            this.textBoxKredi.TabIndex = 66;
            // 
            // labelTutar
            // 
            this.labelTutar.Location = new System.Drawing.Point(224, 351);
            this.labelTutar.Name = "labelTutar";
            this.labelTutar.Size = new System.Drawing.Size(137, 23);
            this.labelTutar.TabIndex = 67;
            this.labelTutar.Text = "Ödeyeceğiniz Tutar:";
            // 
            // labelFiyat
            // 
            this.labelFiyat.Location = new System.Drawing.Point(410, 351);
            this.labelFiyat.Name = "labelFiyat";
            this.labelFiyat.Size = new System.Drawing.Size(40, 23);
            this.labelFiyat.TabIndex = 68;
            this.labelFiyat.Text = "0";
            this.labelFiyat.Click += new System.EventHandler(this.labelFiyat_Click);
            // 
            // labelOdataban
            // 
            this.labelOdataban.Location = new System.Drawing.Point(29, 74);
            this.labelOdataban.Name = "labelOdataban";
            this.labelOdataban.Size = new System.Drawing.Size(147, 39);
            this.labelOdataban.TabIndex = 69;
            this.labelOdataban.Text = "Odanın günlük fiyatı: ";
            // 
            // labelGunluk
            // 
            this.labelGunluk.Location = new System.Drawing.Point(172, 74);
            this.labelGunluk.Name = "labelGunluk";
            this.labelGunluk.Size = new System.Drawing.Size(107, 23);
            this.labelGunluk.TabIndex = 70;
            this.labelGunluk.Text = "0";
            // 
            // buttonOnayla
            // 
            this.buttonOnayla.Location = new System.Drawing.Point(27, 341);
            this.buttonOnayla.Name = "buttonOnayla";
            this.buttonOnayla.Size = new System.Drawing.Size(149, 36);
            this.buttonOnayla.TabIndex = 71;
            this.buttonOnayla.Text = "Hesabı Gör";
            this.buttonOnayla.UseVisualStyleBackColor = true;
            this.buttonOnayla.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.Location = new System.Drawing.Point(32, 433);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(223, 36);
            this.buttonRezYap.TabIndex = 72;
            this.buttonRezYap.Text = "Rezarvasyon Oluştur";
            this.buttonRezYap.UseVisualStyleBackColor = true;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // OnOdeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 616);
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
            this.Name = "OnOdeme";
            this.Text = "OnOdeme";
            this.Load += new System.EventHandler(this.OnOdeme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerRez;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelis;
        private System.Windows.Forms.DateTimePicker dateTimePickerAyrilis;
        private System.Windows.Forms.Label labelGelisTarih;
        private System.Windows.Forms.Label labelAyrilisTarih;
        private System.Windows.Forms.Label labelKredi;
        private System.Windows.Forms.TextBox textBoxKredi;
        private System.Windows.Forms.Label labelTutar;
        private System.Windows.Forms.Label labelFiyat;
        private System.Windows.Forms.Label labelOdataban;
        private System.Windows.Forms.Label labelGunluk;
        private System.Windows.Forms.Button buttonOnayla;
        private System.Windows.Forms.Button buttonRezYap;
    }
}