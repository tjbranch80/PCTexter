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
    public partial class CreateFriend : Form
    {
        #region Global Components

        public CreateFriend()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion

        #region Private Methods

        private void CreateFriend_Load(object sender, EventArgs e)
        {
            GetCarriers();
        }

        private void SaveFriendButton_Click(object sender, EventArgs e)
        {
            DataManager dataManager = new DataManager();
            string name = NameTextBox.Text;
            string phoneNumber = PhoneTextBox.Text;
            string carrier = GetSelectedCarrier();

            dataManager.WriteNewFriend(name, phoneNumber, carrier);

            ShowMessage(name);

            ResetForm();
        }

        #endregion

        #region Public Methods

        public void GetCarriers()
        {
            DataManager dataManager = new DataManager();
            CarrierComboBox.DataSource = dataManager.CreateCarrierList();
        }

        public void ResetForm()
        {
            NameTextBox.Text = String.Empty;
            PhoneTextBox.Text = String.Empty;
        }

        public string GetSelectedCarrier()
        {
            string selectedCarrier = CarrierComboBox.SelectedItem.ToString();
            return selectedCarrier;
        }

        public void ShowMessage(string name)
        {
            MessageBox.Show(String.Format("New Friend: {0} Has Been Saved", name));
        }

        #endregion
    }
}
