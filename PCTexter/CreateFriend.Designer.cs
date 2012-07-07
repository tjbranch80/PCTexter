namespace PCTexter
{
    partial class CreateFriend
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CarrierComboBox = new System.Windows.Forms.ComboBox();
            this.SaveFriendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Friend\'s Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 43);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(221, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Friend\'s 10 Digit Number";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(15, 105);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(221, 20);
            this.PhoneTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Friend\'s Carrier";
            // 
            // CarrierComboBox
            // 
            this.CarrierComboBox.FormattingEnabled = true;
            this.CarrierComboBox.Location = new System.Drawing.Point(15, 163);
            this.CarrierComboBox.Name = "CarrierComboBox";
            this.CarrierComboBox.Size = new System.Drawing.Size(162, 21);
            this.CarrierComboBox.TabIndex = 5;
            // 
            // SaveFriendButton
            // 
            this.SaveFriendButton.Location = new System.Drawing.Point(15, 229);
            this.SaveFriendButton.Name = "SaveFriendButton";
            this.SaveFriendButton.Size = new System.Drawing.Size(99, 23);
            this.SaveFriendButton.TabIndex = 6;
            this.SaveFriendButton.Text = "Save Friend";
            this.SaveFriendButton.UseVisualStyleBackColor = true;
            this.SaveFriendButton.Click += new System.EventHandler(this.SaveFriendButton_Click);
            // 
            // CreateFriend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 354);
            this.Controls.Add(this.SaveFriendButton);
            this.Controls.Add(this.CarrierComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreateFriend";
            this.Text = "Create Friend";
            this.Load += new System.EventHandler(this.CreateFriend_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CarrierComboBox;
        private System.Windows.Forms.Button SaveFriendButton;
    }
}