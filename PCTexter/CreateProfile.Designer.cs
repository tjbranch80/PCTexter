namespace PCTexter
{
    partial class CreateProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.GmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GmailPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveProfileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter A GMail Address";
            // 
            // GmailAddressTextBox
            // 
            this.GmailAddressTextBox.Location = new System.Drawing.Point(15, 45);
            this.GmailAddressTextBox.Name = "GmailAddressTextBox";
            this.GmailAddressTextBox.Size = new System.Drawing.Size(217, 20);
            this.GmailAddressTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Your GMail Account Password";
            // 
            // GmailPasswordTextBox
            // 
            this.GmailPasswordTextBox.Location = new System.Drawing.Point(15, 100);
            this.GmailPasswordTextBox.Name = "GmailPasswordTextBox";
            this.GmailPasswordTextBox.Size = new System.Drawing.Size(217, 20);
            this.GmailPasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter The Name To Display For Sent Messages";
            // 
            // DisplayNameTextBox
            // 
            this.DisplayNameTextBox.Location = new System.Drawing.Point(15, 163);
            this.DisplayNameTextBox.Name = "DisplayNameTextBox";
            this.DisplayNameTextBox.Size = new System.Drawing.Size(217, 20);
            this.DisplayNameTextBox.TabIndex = 5;
            // 
            // SaveProfileButton
            // 
            this.SaveProfileButton.Location = new System.Drawing.Point(15, 221);
            this.SaveProfileButton.Name = "SaveProfileButton";
            this.SaveProfileButton.Size = new System.Drawing.Size(110, 23);
            this.SaveProfileButton.TabIndex = 6;
            this.SaveProfileButton.Text = "Save Profile";
            this.SaveProfileButton.UseVisualStyleBackColor = true;
            this.SaveProfileButton.Click += new System.EventHandler(this.SaveProfileButton_Click);
            // 
            // CreateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 353);
            this.Controls.Add(this.SaveProfileButton);
            this.Controls.Add(this.DisplayNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GmailPasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GmailAddressTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateProfile";
            this.Text = "Create Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GmailAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GmailPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DisplayNameTextBox;
        private System.Windows.Forms.Button SaveProfileButton;
    }
}