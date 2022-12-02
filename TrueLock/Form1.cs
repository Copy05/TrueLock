/*
 * 
 * Copyright Copy05 2016-2023
 * TrueLock is a product by Copy05.
 * 
 * **/

using System;
using System.Threading;
using System.Windows.Forms;
using TrueLock.Util;

namespace TrueLock
{
    public partial class Form1 : Form
    {
        public string Username, Password, WebURL;
        public bool hasEnabledTextEditor, hasEnabledShutdown, hasEnabledTaskKill, hasEnabledWebBrowser;
        string[] args = Environment.GetCommandLineArgs();
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            LockButton.Enabled = true;
            WebURL = URLTB.Text;
            Username = UsernameTextBox.Text;
            Password = PasswordTextBox.Text;
        }

        private void enableTECB_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTECB.Checked)
            {
                hasEnabledTextEditor = true;
            } else
            {
                hasEnabledTextEditor = false;
            }
        }

        private void Lock()
        {

            LoginForm lf = new LoginForm();
            FullscreenLock fsl = new FullscreenLock();
            FullscreenLock fsl2 = new FullscreenLock();
            FullWebBrowser fwb = new FullWebBrowser();
            fwb.Settings = this;
            lf.Settings = this;
            fsl.Settings = this;

            Helpers.KillProcess("explorer.exe");
            if (hasEnabledTaskKill)
            {
                string[] procName = { "chrome.exe", "teams.exe", "edge.exe", "firefox.exe", "word.exe", "excel.exe", "code.exe", 
                    "powerpoint.exe", "outlook.exe", "notepad.exe", "mspaint.exe", "powershell.exe", "minecraft.exe", "access.exe", "discord.exe", "roblox.exe", "cmd.exe" };
                for(int i = 0; i < procName.Length; i++)
                {
                    Helpers.KillProcess(procName[i]);
                }
            }

            fsl2.StartPosition = FormStartPosition.Manual;
            fsl2.Bounds = Screen.AllScreens[0].Bounds;
            fsl2.Show();

            fsl.Show();
            

            if (args.Length > 3 && args[3] == "-browser" || hasEnabledWebBrowser)
            {
                fwb.Show();
                fwb.BringToFront();
            } else
            {
                lf.Show();
            }

            this.Hide();
        }

        private void LockButton_Click(object sender, EventArgs e)
        {

            if (hasEnabledTaskKill || hasEnabledShutdown)
            {
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show("You enabled a setting which can make you lose your work. Do you want to lock this PC?", "TrueLock Warning", buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Lock();
                }

            } else
            {
                Lock();
            }
            
        }

        private void WebEmbedURLTB_TextChanged(object sender, EventArgs e)
        {
            LockButton.Enabled = false;
        }

        private void ShutdownCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShutdownCB.Checked)
            {
                hasEnabledShutdown = true;
            }
            else
            {
                hasEnabledShutdown = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (args.Length > 2)
            {
                this.Hide();
                if (args[3] == "-te" || args[3] == "-TE")
                {
                    hasEnabledTextEditor = true;
                }

                Username = args[1];
                Password = args[2];
                if(Password.Length > 13)
                {
                    MessageBox.Show("Password cannot be longer than 14 characters", "TrueLock CLI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
                Lock();
            }
        }

        private void WebBrowserCB_CheckedChanged(object sender, EventArgs e)
        {
            if (WebBrowserCB.Checked)
            {
                hasEnabledWebBrowser = true;
                URLGB.Visible = true;
            }
            else
            {
                hasEnabledWebBrowser = false;
                URLGB.Visible = false;
            }
        }

        private void URLTB_TextChanged(object sender, EventArgs e)
        {
            LockButton.Enabled = false;
        }

        private void KillAppsCB_CheckedChanged(object sender, EventArgs e)
        {
            if (KillAppsCB.Checked)
            {
                hasEnabledTaskKill = true;
            }
            else
            {
                hasEnabledTaskKill = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void openSplash()
        {
            Application.Run(new TLSplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            URLGB.Visible = false;
            try
            {
                if (args[1] == ("-h") || args[1] == ("-H"))
                {
                    MessageBox.Show(@"TrueLock CLI v1.0 Help:
Usage: ./TrueLock.exe [cmd]

-h 
Shows help

./TrueLock.exe [username] [password]
Sets TrueLock.

-browser [url] 
Sets TrueLock into portal mode, opens a fullscreen web browser with the passed URL

", "TrueLock CLI v1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            } catch
            {
                this.Hide();
                Thread t = new Thread(new ThreadStart(openSplash));
                t.Start();
                Thread.Sleep(2000);
                t.Abort();
            }
        }
    }
}
