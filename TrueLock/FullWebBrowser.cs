/*
 * 
 * Copyright Copy05 2016-2023
 * TrueLock is a product by Copy05.
 * 
 * **/

using System;
using System.Windows.Forms;
using TrueLock.Util;

namespace TrueLock
{
    public partial class FullWebBrowser : Form
    {
        public string Username, Password, WebURL;
        public Form1 Settings = new Form1();
        string[] args = Environment.GetCommandLineArgs();

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!LoginArea.Visible)
            {
                LoginArea.Visible = true;
                LoginButton.Text = "Hide Login";
            }
            else if (LoginArea.Visible)
            {
                LoginArea.Visible = false;
                LoginButton.Text = "Show Login";
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == Username && PasswordTextBox.Text == Password)
            {
                Helpers.ExecuteCommand("start explorer.exe");
                Helpers.KillProcess("iexplore.exe");
                Environment.Exit(0);
            }

            if (UsernameTextBox.Text != Username || PasswordTextBox.Text != Password)
            {
                MessageBox.Show("The login or password is incorrect. please try again", "TrueLock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Device is set to Portal Mode and has been Locked. please contact the system admin for the login credentials", "TrueLock Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BrowserFrame_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            string URL;
            if (args.Length > 2)
            {
                URL = args[4];
            } else
            {
                URL = WebURL;
            }
            
            string url = e.Url.ToString();
            if (!url.StartsWith(URL) || !url.Contains(URL))
            {
                MessageBox.Show("Access Denied.", "TrueLock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            BrowserFrame.GoBack();
        }

        private void goForwardBtn_Click(object sender, EventArgs e)
        {
            BrowserFrame.GoForward();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            BrowserFrame.Refresh();
        }
        public FullWebBrowser()
        {
            InitializeComponent();
        }

        private void FullWebBrowser_Load(object sender, EventArgs e)
        {
            string URL;
            if (args.Length > 2)
            {
                URL = args[4];
                Username = args[1];
                Password = args[2];
                BrowserFrame.Navigate(URL);
            } else
            {
                this.Username = ((Form1)Settings).Username;
                this.Password = ((Form1)Settings).Password;
                this.WebURL = ((Form1)Settings).WebURL;
                BrowserFrame.Navigate(WebURL);
            }
            
            LoginArea.Visible = false;
            
            this.BringToFront();
        }
    }
}
