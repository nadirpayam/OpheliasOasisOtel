
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
            this.SuspendLayout();
            // 
            // buttonRezYap
            // 
            this.buttonRezYap.Location = new System.Drawing.Point(284, 159);
            this.buttonRezYap.Name = "buttonRezYap";
            this.buttonRezYap.Size = new System.Drawing.Size(239, 91);
            this.buttonRezYap.TabIndex = 0;
            this.buttonRezYap.Text = "Rezarvasyon Yap";
            this.buttonRezYap.UseVisualStyleBackColor = true;
            this.buttonRezYap.Click += new System.EventHandler(this.buttonRezYap_Click);
            // 
            // buttonRezlerim
            // 
            this.buttonRezlerim.Location = new System.Drawing.Point(228, 309);
            this.buttonRezlerim.Name = "buttonRezlerim";
            this.buttonRezlerim.Size = new System.Drawing.Size(334, 152);
            this.buttonRezlerim.TabIndex = 1;
            this.buttonRezlerim.Text = "Rezarvasyonlarım";
            this.buttonRezlerim.UseVisualStyleBackColor = true;
            this.buttonRezlerim.Click += new System.EventHandler(this.buttonRezlerim_Click);
            // 
            // MusteriAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(899, 606);
            this.Controls.Add(this.buttonRezlerim);
            this.Controls.Add(this.buttonRezYap);
            this.Name = "MusteriAnasayfa";
            this.Text = "MusteriAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRezYap;
        private System.Windows.Forms.Button buttonRezlerim;
    }
}