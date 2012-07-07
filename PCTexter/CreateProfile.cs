using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCTexter
{
    public partial class CreateProfile : Form
    {
        #region Global Components

        public CreateProfile()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion

        #region Private Methods

        private void SaveProfileButton_Click(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            string emailAddress = GmailAddressTextBox.Text;
            string emailPassword = GmailPasswordTextBox.Text;
            string displayName = DisplayNameTextBox.Text;

            dataManager.WriteNewProfile(emailAddress, emailPassword, displayName);

            ShowMessage(emailAddress);

            ResetForm();
        }

        #endregion

        #region Public Methods

        public void ResetForm()
        {
            GmailAddressTextBox.Text = String.Empty;
            GmailPasswordTextBox.Text = String.Empty;
            DisplayNameTextBox.Text = String.Empty;
        }

        public void ShowMessage(string emailAddress)
        {
            MessageBox.Show(String.Format("Profile For Email Address: {0} Has Been Saved", emailAddress));
        }

        #endregion
    }
}
