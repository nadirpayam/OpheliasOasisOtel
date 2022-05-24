
namespace OpheliasOasisOtel
{
    partial class Yedekleme
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
            this.labelServer = new System.Windows.Forms.Label();
            this.labeldatabase = new System.Windows.Forms.Label();
            this.labelpath = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonYedekle = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // labelServer
            // 
            this.labelServer.Location = new System.Drawing.Point(33, 105);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(100, 23);
            this.labelServer.TabIndex = 0;
            this.labelServer.Text = "Server:";
            // 
            // labeldatabase
            // 
            this.labeldatabase.Location = new System.Drawing.Point(33, 187);
            this.labeldatabase.Name = "labeldatabase";
            this.labeldatabase.Size = new System.Drawing.Size(100, 23);
            this.labeldatabase.TabIndex = 1;
            this.labeldatabase.Text = "Database:";
            // 
            // labelpath
            // 
            this.labelpath.Location = new System.Drawing.Point(33, 277);
            this.labelpath.Name = "labelpath";
            this.labelpath.Size = new System.Drawing.Size(100, 23);
            this.labelpath.TabIndex = 2;
            this.labelpath.Text = "Path:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(139, 188);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "okulum";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(139, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonYedekle
            // 
            this.buttonYedekle.Location = new System.Drawing.Point(164, 368);
            this.buttonYedekle.Name = "buttonYedekle";
            this.buttonYedekle.Size = new System.Drawing.Size(75, 23);
            this.buttonYedekle.TabIndex = 7;
            this.buttonYedekle.Text = "Yedekle";
            this.buttonYedekle.UseVisualStyleBackColor = true;
            this.buttonYedekle.Click += new System.EventHandler(this.buttonYedekle_Click);
            // 
            // Yedekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.buttonYedekle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelpath);
            this.Controls.Add(this.labeldatabase);
            this.Controls.Add(this.labelServer);
            this.Name = "Yedekleme";
            this.Text = "Yedekleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labeldatabase;
        private System.Windows.Forms.Label labelpath;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonYedekle;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}