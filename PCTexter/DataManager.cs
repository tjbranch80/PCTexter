using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EAGetMail;

namespace PCTexter
{
    class DataManager
    {
        #region Global Compoents

        readonly string applicationDirectory = @"C:\PCTexter";
        readonly string saveProfilePath = @"C:\PCTexter\Profiles.txt";
        readonly string saveFriendPath = @"C:\PCTexter\Friends.txt";

        #endregion

        #region Write Methods

        public void WriteNewProfile(string emailAddress, string emailPassword, string displayName)
        {
            try
            {
                if (!Directory.Exists(applicationDirectory))
                {
                    Directory.CreateDirectory(applicationDirectory);
                    using (StreamWriter createFile = File.CreateText(saveProfilePath))
                    {
                        createFile.Close();
                    }
                }

                if (!File.Exists(saveProfilePath))
                {
                    using (StreamWriter createHeader = new StreamWriter(saveProfilePath, true))
                    {
                        createHeader.WriteLine("EmailAddress" + "," + "EmailPassword" + "," + "DisplayName");
                        createHeader.Close();
                    }
                }

                if (File.Exists(saveProfilePath))
                {
                    using (StreamWriter writeProfile = new StreamWriter(saveProfilePath, true))
                    {
                        writeProfile.WriteLine(emailAddress + "," + emailPassword + "," + displayName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void WriteNewFriend(string name, string phoneNumber, string carrier)
        {
            try
            {
                if (!Directory.Exists(applicationDirectory))
                {
                    Directory.CreateDirectory(applicationDirectory);
                    using (StreamWriter createFile = File.CreateText(saveFriendPath))
                    {
                        createFile.Close();
                    }
                }

                if (!File.Exists(saveFriendPath))
                {
                    using (StreamWriter createHeader = new StreamWriter(saveFriendPath, true))
                    {
                        createHeader.WriteLine("Name" + "," + "PhoneNumber" + "," + "Carrier");
                        createHeader.Close();
                    }
                }

                if (File.Exists(saveFriendPath))
                {
                    using (StreamWriter writeFriend = new StreamWriter(saveFriendPath, true))
                    {
                        writeFriend.WriteLine(name + "," + phoneNumber + "," + carrier);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        #endregion

        #region Get Data Methods

        public DataTable GetAllProfiles()
        {
            string[] Lines = File.ReadAllLines(saveProfilePath);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ',' });
            int Cols = Fields.GetLength(0);
            DataTable profileTable = new DataTable();

            for (int i = 0; i < Cols; i++)
            {
                profileTable.Columns.Add(Fields[i], typeof(string));
            }
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(new char[] { ',' });
                Row = profileTable.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = Fields[f];
                profileTable.Rows.Add(Row);
            }

            return profileTable;
        }

        public DataTable GetAllFriends()
        {
            string[] Lines = File.ReadAllLines(saveFriendPath);
            string[] Fields;
            Fields = Lines[0].Split(new char[] { ',' });
            int Cols = Fields.GetLength(0);
            DataTable friendTable = new DataTable();

            for (int i = 0; i < Cols; i++)
            {
                friendTable.Columns.Add(Fields[i], typeof(string));
            }
            DataRow Row;
            for (int i = 1; i < Lines.GetLength(0); i++)
            {
                Fields = Lines[i].Split(new char[] { ',' });
                Row = friendTable.NewRow();
                for (int f = 0; f < Cols; f++)
                    Row[f] = Fields[f];
                friendTable.Rows.Add(Row);
            }

            return friendTable;
        }

        #endregion

        #region Misc Methods

        public string[] CreateCarrierList()
        {
            List<string> carrierList = new List<string>();
            carrierList.Add("AT&T");
            carrierList.Add("SprintPCS");
            string[] carrierArray = carrierList.ToArray();

            return carrierArray;
        }

        #endregion

        #region Receive Messages

        public string CreateInbox()
        {
            string mailBox = @"C:\Inbox\";
            if (!Directory.Exists(mailBox))
            {
                Directory.CreateDirectory(mailBox);
            }

            return mailBox;
        }

        public MailServer CreateMailServer()
        {
            MailServer oServer = new MailServer("imap.gmail.com", "tj.branch80@gmail.com", "hulksmash1", ServerProtocol.Imap4);
            oServer.SSLConnection = true;
            oServer.Port = 993;

            return oServer;
        }

        public DataTable CaptureMessages()
        {
            MailClient oClient = new MailClient("TryIt");
            MailServer oServer = CreateMailServer();

            oClient.Connect(oServer);
            MailInfo[] infos = oClient.GetMailInfos();
            DataTable emailTable = new DataTable();
            emailTable.Columns.Add("From", typeof(string));
            emailTable.Columns.Add("Body", typeof(string));
            string mailBox = CreateInbox();

            for (int i = 0; i < infos.Length; i++)
            {
                MailInfo info = infos[i];
                Mail oMail = oClient.GetMail(info);

                System.DateTime d = System.DateTime.Now;
                System.Globalization.CultureInfo cur = new System.Globalization.CultureInfo("en-US");
                string sDate = d.ToString("yyyyMMddHHmmss", cur);
                string fileName = String.Format("{0}\\{1}{2}{3}.eml", mailBox, sDate, d.Millisecond.ToString("d3"), i);
                oMail.SaveAs(fileName, true);
                string from = oMail.From.ToString();
                string displayFrom = from.Substring(1, 10);
                emailTable.Rows.Add(displayFrom, oMail.TextBody);
            }

            return emailTable;
        }

        //public DataTable GetFriendsNames()
        //{
        //    DataTable friendInformationTable = new DataTable();
        //    friendInformationTable = GetAllFriends();

        //    var query = from q in friendInformationTable.AsEnumerable()
        //                select new { PhoneNumber = q.Field<string>("PhoneNumber"), Name = q.Field<string>("Name") };

           
        //    string[] friendsNames = friendInformationTable
        //                            .AsEnumerable()
        //                            .Select(row => row.Field<string>("PhoneNumber"))
        //                            .ToArray();

        //    DataTable friendNameTable = new DataTable();
        //    friendNameTable.Columns.Add("PhoneNumber", typeof(string));
        //    friendNameTable.Columns.Add("Name",typeof(string));
        //    foreach (var record in query)
        //    {
        //        friendNameTable.Rows.Add(record);
        //    }

        //    return friendNameTable;
        //}

        public DataTable MockCaptureMessages()
        {
            DataTable emailTable = new DataTable();
            emailTable.Columns.Add("From", typeof(string));
            emailTable.Columns.Add("Body", typeof(string));

            emailTable.Rows.Add("1", "Test 1");
            emailTable.Rows.Add("1", "Test 2");
            emailTable.Rows.Add("2", "Test 3");

            return emailTable;
        }

        public DataTable MockGetFriendsNames()
        {
            DataTable emailTable = new DataTable();
            emailTable.Columns.Add("PhoneNumber", typeof(string));
            emailTable.Columns.Add("Name", typeof(string));

            emailTable.Rows.Add("1", "Name 1");
            emailTable.Rows.Add("1", "Name 1");
            emailTable.Rows.Add("2", "Name 2");

            return emailTable;
        }

        #endregion
    }
}
