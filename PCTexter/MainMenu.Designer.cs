namespace PCTexter
{
    partial class MainMenu
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
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.CreateProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFriendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.ProfileComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FriendComboBox = new System.Windows.Forms.ComboBox();
            this.ReceivedTreeView = new System.Windows.Forms.TreeView();
            this.DisplayMessagesButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProfileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateFriendToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(15, 282);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(142, 23);
            this.SendMessageButton.TabIndex = 0;
            this.SendMessageButton.Text = "Send Text Message";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select A Friend To Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Type In Message To Send";
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(15, 179);
            this.MessageTextBox.Multiline = true;
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(220, 83);
            this.MessageTextBox.TabIndex = 7;
            // 
            // ProfileComboBox
            // 
            this.ProfileComboBox.FormattingEnabled = true;
            this.ProfileComboBox.Location = new System.Drawing.Point(15, 64);
            this.ProfileComboBox.Name = "ProfileComboBox";
            this.ProfileComboBox.Size = new System.Drawing.Size(142, 21);
            this.ProfileComboBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select A Profile";
            // 
            // FriendComboBox
            // 
            this.FriendComboBox.FormattingEnabled = true;
            this.FriendComboBox.Location = new System.Drawing.Point(15, 121);
            this.FriendComboBox.Name = "FriendComboBox";
            this.FriendComboBox.Size = new System.Drawing.Size(142, 21);
            this.FriendComboBox.TabIndex = 10;
            // 
            // ReceivedTreeView
            // 
            this.ReceivedTreeView.Location = new System.Drawing.Point(15, 360);
            this.ReceivedTreeView.Name = "ReceivedTreeView";
            this.ReceivedTreeView.Size = new System.Drawing.Size(265, 243);
            this.ReceivedTreeView.TabIndex = 11;
            // 
            // DisplayMessagesButton
            // 
            this.DisplayMessagesButton.Location = new System.Drawing.Point(68, 328);
            this.DisplayMessagesButton.Name = "DisplayMessagesButton";
            this.DisplayMessagesButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayMessagesButton.TabIndex = 12;
            this.DisplayMessagesButton.Text = "button1";
            this.DisplayMessagesButton.UseVisualStyleBackColor = true;
            this.DisplayMessagesButton.Click += new System.EventHandler(this.DisplayMessagesButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateProfileToolStripMenuItem1,
            this.CreateFriendToolStripMenuItem1});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // CreateProfileToolStripMenuItem1
            // 
            this.CreateProfileToolStripMenuItem1.Name = "CreateProfileToolStripMenuItem1";
            this.CreateProfileToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.CreateProfileToolStripMenuItem1.Text = "Create Profile";
            this.CreateProfileToolStripMenuItem1.Click += new System.EventHandler(this.CreateProfileToolStripMenuItem1_Click);
            // 
            // CreateFriendToolStripMenuItem1
            // 
            this.CreateFriendToolStripMenuItem1.Name = "CreateFriendToolStripMenuItem1";
            this.CreateFriendToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.CreateFriendToolStripMenuItem1.Text = "Create Friend";
            this.CreateFriendToolStripMenuItem1.Click += new System.EventHandler(this.CreateFriendToolStripMenuItem1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 615);
            this.Controls.Add(this.DisplayMessagesButton);
            this.Controls.Add(this.ReceivedTreeView);
            this.Controls.Add(this.FriendComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProfileComboBox);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.ToolStripMenuItem CreateProfileToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.ComboBox ProfileComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem CreateFriendToolStripMenuItem;
        private System.Windows.Forms.ComboBox FriendComboBox;
        private System.Windows.Forms.TreeView ReceivedTreeView;
        private System.Windows.Forms.Button DisplayMessagesButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateProfileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateFriendToolStripMenuItem1;
    }
}

