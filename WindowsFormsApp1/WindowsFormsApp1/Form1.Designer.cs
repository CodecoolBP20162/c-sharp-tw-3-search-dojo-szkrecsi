namespace WindowsFormsApp1
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
            this.lblText = new System.Windows.Forms.Label();
            this.lblMatched = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtMatched = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(25, 13);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // lblMatched
            // 
            this.lblMatched.AutoSize = true;
            this.lblMatched.Location = new System.Drawing.Point(323, 13);
            this.lblMatched.Name = "lblMatched";
            this.lblMatched.Size = new System.Drawing.Size(49, 13);
            this.lblMatched.TabIndex = 1;
            this.lblMatched.Text = "Matched";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(28, 339);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(41, 13);
            this.lblPattern.TabIndex = 2;
            this.lblPattern.Text = "Pattern";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(362, 365);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(31, 368);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(327, 20);
            this.txtPattern.TabIndex = 4;
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(28, 40);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(198, 284);
            this.txtText.TabIndex = 5;
            // 
            // txtMatched
            // 
            this.txtMatched.Location = new System.Drawing.Point(258, 40);
            this.txtMatched.Multiline = true;
            this.txtMatched.Name = "txtMatched";
            this.txtMatched.Size = new System.Drawing.Size(179, 284);
            this.txtMatched.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 414);
            this.Controls.Add(this.txtMatched);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblMatched);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblMatched;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtMatched;
    }
}

