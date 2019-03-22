namespace FinnishBBANConverter
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
            this.textBoxInput1 = new System.Windows.Forms.TextBox();
            this.buttonConvert1 = new System.Windows.Forms.Button();
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.labelCredits1 = new System.Windows.Forms.Label();
            this.textBoxResponse1 = new System.Windows.Forms.TextBox();
            this.textBoxCheck1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxChecksumValidity1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelProductVersion = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput1
            // 
            this.textBoxInput1.Location = new System.Drawing.Point(15, 43);
            this.textBoxInput1.MaxLength = 15;
            this.textBoxInput1.Name = "textBoxInput1";
            this.textBoxInput1.Size = new System.Drawing.Size(108, 20);
            this.textBoxInput1.TabIndex = 0;
            // 
            // buttonConvert1
            // 
            this.buttonConvert1.Location = new System.Drawing.Point(136, 41);
            this.buttonConvert1.Name = "buttonConvert1";
            this.buttonConvert1.Size = new System.Drawing.Size(140, 23);
            this.buttonConvert1.TabIndex = 1;
            this.buttonConvert1.Text = "Convert to Long Format";
            this.buttonConvert1.UseVisualStyleBackColor = true;
            this.buttonConvert1.Click += new System.EventHandler(this.buttonConvert1_Click);
            // 
            // labelHelp1
            // 
            this.labelHelp1.AutoSize = true;
            this.labelHelp1.Location = new System.Drawing.Point(12, 9);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(301, 13);
            this.labelHelp1.TabIndex = 3;
            this.labelHelp1.Text = "Add a short format Finnish bank account number down bellow.";
            // 
            // labelCredits1
            // 
            this.labelCredits1.AutoSize = true;
            this.labelCredits1.Location = new System.Drawing.Point(85, 190);
            this.labelCredits1.Name = "labelCredits1";
            this.labelCredits1.Size = new System.Drawing.Size(191, 13);
            this.labelCredits1.TabIndex = 4;
            this.labelCredits1.Text = "Application created by Onni Kytönummi";
            // 
            // textBoxResponse1
            // 
            this.textBoxResponse1.Location = new System.Drawing.Point(15, 84);
            this.textBoxResponse1.Name = "textBoxResponse1";
            this.textBoxResponse1.ReadOnly = true;
            this.textBoxResponse1.Size = new System.Drawing.Size(108, 20);
            this.textBoxResponse1.TabIndex = 5;
            // 
            // textBoxCheck1
            // 
            this.textBoxCheck1.Location = new System.Drawing.Point(15, 110);
            this.textBoxCheck1.Name = "textBoxCheck1";
            this.textBoxCheck1.ReadOnly = true;
            this.textBoxCheck1.Size = new System.Drawing.Size(108, 20);
            this.textBoxCheck1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Long Format Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calculated Checksum";
            // 
            // textBoxChecksumValidity1
            // 
            this.textBoxChecksumValidity1.Location = new System.Drawing.Point(15, 136);
            this.textBoxChecksumValidity1.Name = "textBoxChecksumValidity1";
            this.textBoxChecksumValidity1.ReadOnly = true;
            this.textBoxChecksumValidity1.Size = new System.Drawing.Size(108, 20);
            this.textBoxChecksumValidity1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Checksum Validity";
            // 
            // labelProductVersion
            // 
            this.labelProductVersion.AutoSize = true;
            this.labelProductVersion.Location = new System.Drawing.Point(85, 211);
            this.labelProductVersion.Name = "labelProductVersion";
            this.labelProductVersion.Size = new System.Drawing.Size(81, 13);
            this.labelProductVersion.TabIndex = 9;
            this.labelProductVersion.Text = "Product version";
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(172, 211);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(82, 13);
            this.labelVersion.TabIndex = 10;
            this.labelVersion.Text = "Version Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 236);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelProductVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxChecksumValidity1);
            this.Controls.Add(this.textBoxCheck1);
            this.Controls.Add(this.textBoxResponse1);
            this.Controls.Add(this.labelCredits1);
            this.Controls.Add(this.labelHelp1);
            this.Controls.Add(this.buttonConvert1);
            this.Controls.Add(this.textBoxInput1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Finnish BBAN Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput1;
        private System.Windows.Forms.Button buttonConvert1;
        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.Label labelCredits1;
        private System.Windows.Forms.TextBox textBoxResponse1;
        private System.Windows.Forms.TextBox textBoxCheck1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxChecksumValidity1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelProductVersion;
        private System.Windows.Forms.Label labelVersion;
    }
}

