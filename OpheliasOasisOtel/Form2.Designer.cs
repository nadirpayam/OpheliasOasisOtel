
namespace OpheliasOasisOtel
{
    partial class Form2
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
            this.dateTimePickerAyrilis = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerGelis = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerAyrilis
            // 
            this.dateTimePickerAyrilis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAyrilis.Location = new System.Drawing.Point(235, 122);
            this.dateTimePickerAyrilis.Name = "dateTimePickerAyrilis";
            this.dateTimePickerAyrilis.Size = new System.Drawing.Size(351, 22);
            this.dateTimePickerAyrilis.TabIndex = 8;
            // 
            // dateTimePickerGelis
            // 
            this.dateTimePickerGelis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerGelis.Location = new System.Drawing.Point(235, 68);
            this.dateTimePickerGelis.Name = "dateTimePickerGelis";
            this.dateTimePickerGelis.Size = new System.Drawing.Size(351, 22);
            this.dateTimePickerGelis.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(232, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerAyrilis);
            this.Controls.Add(this.dateTimePickerGelis);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAyrilis;
        private System.Windows.Forms.DateTimePicker dateTimePickerGelis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}