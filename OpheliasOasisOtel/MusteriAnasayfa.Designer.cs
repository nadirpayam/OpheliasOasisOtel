
namespace OpheliasOasisOtel
{
    partial class MusteriAnasayfa
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
            this.buttonRezYap = new System.Windows.Forms.Button();
            this.buttonRezlerim = new System.Windows.Forms.Button();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRezYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRezYap.Location = new System.Drawing.Point(305, 181);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(239, 76);
            this.buttonRezYap.TabIndex = 0;
            this.buttonRezYap.Text = "Rezarvasyon Yap";
            this.buttonRezYap.UseVisualStyleBackColor = false;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // buttonRezlerim
            // 
            this.buttonRezlerim.BackColor = System.Drawing.Color.LightSalmon;
            this.buttonRezlerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonRezlerim.Location = new System.Drawing.Point(305, 286);
            this.buttonRezlerim.Name = "buttonRezlerim";
            this.buttonRezlerim.Size = new System.Drawing.Size(239, 81);
            this.buttonRezlerim.TabIndex = 1;
            this.buttonRezlerim.Text = "Rezarvasyonlarım";
            this.buttonRezlerim.UseVisualStyleBackColor = false;
            this.buttonRezlerim.Click += new System.EventHandler(this.buttonRezlerim_Click);
            // 
            // buttonCikis
            // 
            this.buttonCikis.BackColor = System.Drawing.Color.Transparent;
            this.buttonCikis.FlatAppearance.BorderSize = 0;
            this.buttonCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCikis.Font = new System.Drawing.Font("Constantia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCikis.ForeColor = System.Drawing.Color.Maroon;
            this.buttonCikis.Location = new System.Drawing.Point(802, 12);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(85, 76);
            this.buttonCikis.TabIndex = 40;
            this.buttonCikis.Text = "X";
            this.buttonCikis.UseVisualStyleBackColor = false;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // MusteriAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 606);
            this.Controls.Add(this.buttonCikis);
            this.Controls.Add(this.buttonRezlerim);
            this.Controls.Add(this.buttonRezYap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusteriAnasayfa";
            this.Text = "MusteriAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button buttonRezlerim;
        private System.Windows.Forms.Button buttonCikis;
    }
}