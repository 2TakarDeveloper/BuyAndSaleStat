using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImapX;
using ImapX.Collections;
using MetroFramework;

using TradeInfoSearchApp.Core;
using Message = ImapX.Message;

namespace TradeInfoSearchApp.Forms
{
    public partial class LicenceDialague : MetroFramework.Forms.MetroForm
    {

        private bool Halted { get; set; }

        private bool Valid { get; set; }

        public LicenceDialague()
        {
            Halted = true;
            InitializeComponent();
            ControlBox = false;
        }


        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = Halted;
        }

        private void CancleButton_Click(object sender, EventArgs e)
        {
            Halted = false;

            DialogResult = DialogResult.Cancel;
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            metroProgressBar1.Visible = true;
            backgroundWorker.RunWorkerAsync();
          
        }


        private bool GetMail(string licence)
        {
            backgroundWorker.ReportProgress(10);
            try
            {
                using (ImapClient client = new ImapClient("imap.gmail.com", true))
                {
                    backgroundWorker.ReportProgress(15);
                    client.Connect();
                    backgroundWorker.ReportProgress(20);
                    client.Login("tradeinfosearch@gmail.com", "darks1d1ers");
                    backgroundWorker.ReportProgress(25);

                    Message[] messageCollection=
                        client.Folders.Inbox.Search();
               
                    backgroundWorker.ReportProgress(50);
                
                    foreach (var message in messageCollection)
                    {
                        if (message.Subject == licence)
                        {

                            backgroundWorker.ReportProgress(70);
                            message.Remove();
                            backgroundWorker.ReportProgress(100);
                            return true;
                        }
                    
                    }
               
                    

                }
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "Check Internet Connection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Valid = GetMail(LicenceBox.Text);
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Valid)
            {
                UserSettings.Enabled = true;
                UserSettings.SaveSettings();
                Halted = false;
                DialogResult = DialogResult.OK;
            }
            else
            {
                metroProgressBar1.Value = 0;
                metroProgressBar1.Visible = false;
                MetroMessageBox.Show(this, "Invalid Key", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }

      
    }
}
