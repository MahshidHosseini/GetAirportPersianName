namespace GetPersianNameOfAirports
{
    partial class Form1
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
            this.btnGetAirportsName = new System.Windows.Forms.Button();
            this.txtChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetAirportsName
            // 
            this.btnGetAirportsName.Location = new System.Drawing.Point(72, 160);
            this.btnGetAirportsName.Name = "btnGetAirportsName";
            this.btnGetAirportsName.Size = new System.Drawing.Size(211, 23);
            this.btnGetAirportsName.TabIndex = 0;
            this.btnGetAirportsName.Text = "Airport Names";
            this.btnGetAirportsName.UseVisualStyleBackColor = true;
            this.btnGetAirportsName.Click += new System.EventHandler(this.btnGetAirportsName_Click);
            // 
            // txtChar
            // 
            this.txtChar.Location = new System.Drawing.Point(191, 76);
            this.txtChar.MaxLength = 1;
            this.txtChar.Name = "txtChar";
            this.txtChar.Size = new System.Drawing.Size(100, 20);
            this.txtChar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtChar);
            this.Controls.Add(this.btnGetAirportsName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAirportsName;
        private System.Windows.Forms.TextBox txtChar;
        private System.Windows.Forms.Label label1;
    }
}

