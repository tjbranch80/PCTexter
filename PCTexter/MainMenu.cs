using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

// Enable user to edit their profile.
// Enable user to edit their friends list.
// Perform Code Clean Up.

namespace PCTexter
{
    public partial class MainMenu : Form
    {
        #region Global Compoents

        public MainMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion

        #region Private Methods

        private void MainMenu_Load(object sender, EventArgs e)
        {
            GetProfileDisplayNames();
            GetFriendName();
        }

        private void SendMessageButton_Click(object sender, EventArgs e)
        {
            SmtpClient senderClient = CreateClient();
            MailMessage message = CreateMessage();

            try
            {
                senderClient.Send(message);
                MessageBox.Show("Message Was Sent");
                MessageTextBox.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateProfile createProfile = new CreateProfile();
            createProfile.Show();
        }

        private void CreateFriendToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateFriend createFriend = new CreateFriend();
            createFriend.Show();
        }

        #endregion

        #region Public Methods

        #region Send Messages

        public MailMessage CreateMessage()
        {
            MailMessage message = new MailMessage();
            string phoneNumber = GetPhoneNumber();
            string carrier = GetCarrier();
            string toNumber = String.Format("{0}{1}", phoneNumber, carrier);
            string displayName = ProfileComboBox.SelectedItem.ToString();
            string emailAddress = GetEmailAddress();

            message.To.Add(toNumber);
            message.From = new MailAddress(emailAddress, displayName);
            message.Body = MessageTextBox.Text;

            return message;
        }

        public SmtpClient CreateClient()
        {
            string emailAddress = GetEmailAddress();
            string emailPassword = GetEmailPassword();
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Credentials = new NetworkCredential(emailAddress, emailPassword);

            return smtpClient;
        }

        public void GetProfileDisplayNames()
        {
            DataManager dataManager = new DataManager();
            DataTable profileTable = new DataTable();

            profileTable = dataManager.GetAllProfiles();

            string[] displayNames = profileTable
                                    .AsEnumerable()
                                    .Select(row => row.Field<string>("DisplayName"))
                                    .ToArray();
            ProfileComboBox.DataSource = displayNames;
        }

        public void GetFriendName()
        {
            DataManager dataManager = new DataManager();
            DataTable friendTable = new DataTable();

            friendTable = dataManager.GetAllFriends();

            string[] friendNames = friendTable
                                   .AsEnumerable()
                                   .Select(row => row.Field<string>("Name"))
                                   .ToArray();
            FriendComboBox.DataSource = friendNames;
        }

        public string GetEmailAddress()
        {
            DataManager dataManager = new DataManager();
            DataTable profileTable = new DataTable();

            profileTable = dataManager.GetAllProfiles();

            string emailAddress = null;
            string displayName = ProfileComboBox.SelectedItem.ToString();
            DataRow[] foundRows = profileTable
                                  .AsEnumerable()
                                  .Where(row => row.Field<string>("DisplayName") == displayName)
                                  .ToArray();

            for (int i = 0; i < foundRows.Length; i++)
            {
                emailAddress = foundRows[i][0].ToString();
            }

            return emailAddress;
        }

        public string GetEmailPassword()
        {
            DataManager dataManager = new DataManager();
            DataTable profileTable = new DataTable();

            profileTable = dataManager.GetAllProfiles();

            string emailPassword = null;
            string displayName = ProfileComboBox.SelectedItem.ToString();
            DataRow[] foundRows = profileTable
                                  .AsEnumerable()
                                  .Where(row => row.Field<string>("DisplayName") == displayName)
                                  .ToArray();

            for (int i = 0; i < foundRows.Length; i++)
            {
                emailPassword = foundRows[i][1].ToString();
            }

            return emailPassword;
        }

        public string GetCarrier()
        {
            DataManager dataManager = new DataManager();
            DataTable friendTable = new DataTable();

            friendTable = dataManager.GetAllFriends();

            string carrier = null;
            string friendsCarrier = null;
            string friendName = FriendComboBox.SelectedItem.ToString();
            DataRow[] foundRows = friendTable
                                  .AsEnumerable()
                                  .Where(row => row.Field<string>("Name") == friendName)
                                  .ToArray();
            for (int i = 0; i < foundRows.Length; i++)
            {
                carrier = foundRows[i][2].ToString();
            }

            if (carrier == "AT&T")
            {
                friendsCarrier = "@txt.att.net";
            }

            if (carrier == "SprintPCS")
            {
                friendsCarrier = "@messaging.sprintpcs.com";
            }

            return friendsCarrier;
        }

        public string GetPhoneNumber()
        {
            DataManager dataManager = new DataManager();
            DataTable friendTable = new DataTable();

            friendTable = dataManager.GetAllFriends();

            string phoneNumber = null;
            string friendName = FriendComboBox.SelectedItem.ToString();
            DataRow[] foundRows = friendTable
                                  .AsEnumerable()
                                  .Where(row => row.Field<string>("Name") == friendName)
                                  .ToArray();

            for (int i = 0; i < foundRows.Length; i++)
            {
                phoneNumber = foundRows[i][1].ToString();
            }

            return phoneNumber;
        }

        #endregion

        #region Receive Messages

        public void GetMessages()
        {
            DataManager dataManager = new DataManager();
            DataTable receivedMessagesTable = new DataTable();
            receivedMessagesTable = dataManager.MockCaptureMessages();
            DataTable friendsTable = new DataTable(); 
            friendsTable = dataManager.MockGetFriendsNames();
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(friendsTable);
            dataSet.Tables.Add(receivedMessagesTable);

            dataSet.Relations.Add("children", friendsTable.Columns["PhoneNumber"], receivedMessagesTable.Columns["From"]);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                ReceivedTreeView.Nodes.Clear();

                foreach (DataRow masterRow in dataSet.Tables[0].Rows)
                {
                    TreeNode masterNode = new TreeNode((string)masterRow["PhoneNumber"]);
                    masterNode.Tag = masterRow["Name"];
                    ReceivedTreeView.Nodes.Add(masterNode);

                    foreach (DataRow childRow in masterRow.GetChildRows("children"))
                    {
                        TreeNode childNode = new TreeNode((string)childRow["Body"]);
                        masterNode.Nodes.Add(childNode);
                    }
                }
            }

        }

        #endregion

        private void DisplayMessagesButton_Click(object sender, EventArgs e)
        {
            GetMessages();
        }

        #endregion

        
    }
}
