
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
            this.buttonOnOdeme = new System.Windows.Forms.Button();
            this.button60gun = new System.Windows.Forms.Button();
            this.buttonStandart = new System.Windows.Forms.Button();
            this.buttonTesvik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(763, 9);
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
            this.labelRezAnasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRezAnasayfa.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelRezAnasayfa.Location = new System.Drawing.Point(100, 29);
            this.labelRezAnasayfa.Name = "labelRezAnasayfa";
            this.labelRezAnasayfa.Size = new System.Drawing.Size(625, 71);
            this.labelRezAnasayfa.TabIndex = 77;
            this.labelRezAnasayfa.Text = "REZARVASYON ANASAYFA";
            this.labelRezAnasayfa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelistek
            // 
            this.labelistek.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.labelistek.Location = new System.Drawing.Point(31, 144);
            this.labelistek.Name = "labelistek";
            this.labelistek.Size = new System.Drawing.Size(405, 23);
            this.labelistek.TabIndex = 78;
            this.labelistek.Text = "Yapmak istediğiniz rezarvasyon tipine tıklayınız.";
            // 
            // buttonOnOdeme
            // 
            this.buttonOnOdeme.Location = new System.Drawing.Point(300, 202);
            this.buttonOnOdeme.Name = "buttonOnOdeme";
            this.buttonOnOdeme.Size = new System.Drawing.Size(164, 55);
            this.buttonOnOdeme.TabIndex = 80;
            this.buttonOnOdeme.Text = "Ön Ödemeli Rezarvasyon";
            this.buttonOnOdeme.UseVisualStyleBackColor = true;
            this.buttonOnOdeme.Click += new System.EventHandler(this.buttonOnOdeme_Click);
            // 
            // button60gun
            // 
            this.button60gun.Location = new System.Drawing.Point(300, 321);
            this.button60gun.Name = "button60gun";
            this.button60gun.Size = new System.Drawing.Size(164, 55);
            this.button60gun.TabIndex = 81;
            this.button60gun.Text = "60 Gün Önceden Rezarvasyon";
            this.button60gun.UseVisualStyleBackColor = true;
            this.button60gun.Click += new System.EventHandler(this.button60gun_Click);
            // 
            // buttonStandart
            // 
            this.buttonStandart.Location = new System.Drawing.Point(300, 433);
            this.buttonStandart.Name = "buttonStandart";
            this.buttonStandart.Size = new System.Drawing.Size(164, 55);
            this.buttonStandart.TabIndex = 82;
            this.buttonStandart.Text = "Standart(klasik) Rezarvasyon";
            this.buttonStandart.UseVisualStyleBackColor = true;
            this.buttonStandart.Click += new System.EventHandler(this.buttonStandart_Click);
            // 
            // buttonTesvik
            // 
            this.buttonTesvik.Location = new System.Drawing.Point(300, 562);
            this.buttonTesvik.Name = "buttonTesvik";
            this.buttonTesvik.Size = new System.Drawing.Size(164, 55);
            this.buttonTesvik.TabIndex = 83;
            this.buttonTesvik.Text = "Teşvik Rezarvasyon";
            this.buttonTesvik.UseVisualStyleBackColor = true;
            this.buttonTesvik.Click += new System.EventHandler(this.buttonTesvik_Click);
            // 
            // RezarvasyonAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 777);
            this.Controls.Add(this.buttonTesvik);
            this.Controls.Add(this.buttonStandart);
            this.Controls.Add(this.button60gun);
            this.Controls.Add(this.buttonOnOdeme);
            this.Controls.Add(this.labelistek);
            this.Controls.Add(this.labelRezAnasayfa);
            this.Controls.Add(this.buttonCikis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RezarvasyonAnasayfa";
            this.Text = "RezarvasyonAnasayfa";
            this.Load += new System.EventHandler(this.RezarvasyonAnasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCikis;
        private System.Windows.Forms.Label labelRezAnasayfa;
        private System.Windows.Forms.Label labelistek;
        private System.Windows.Forms.Button buttonOnOdeme;
        private System.Windows.Forms.Button button60gun;
        private System.Windows.Forms.Button buttonStandart;
        private System.Windows.Forms.Button buttonTesvik;
    }
}