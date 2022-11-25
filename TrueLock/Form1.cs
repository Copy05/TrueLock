using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TrueLock.Util;

namespace TrueLock
{
    public partial class Form1 : Form
    {
        public string Username, Password, WebURL;
        public bool hasEnabledTextEditor, hasEnabledShutdown, hasEnabledTaskKill;

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            LockButton.Enabled = true;
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
            Screen[] screens = Screen.AllScreens;

            LoginForm lf = new LoginForm();
            FullscreenLock fsl = new FullscreenLock();
            FullscreenLock fsl2 = new FullscreenLock();
            lf.Settings = this;
            fsl.Settings = this;

            Helpers.KillProcess("explorer.exe");
            if (hasEnabledTaskKill)
            {
                string[] procName = { "chrome.exe", "teams.exe", "edge.exe", "firefox.exe", "word.exe", "excel.exe", "code.exe", 
                    "powerpoint.exe", "outlook.exe", "notepad.exe", "mspaint.exe", "powershell.exe", "minecraft.exe", "access.exe" };
                for(int i = 0; i < procName.Length; i++)
                {
                    Helpers.KillProcess(procName[i]);
                }
            }

            fsl2.StartPosition = FormStartPosition.Manual;
            fsl2.Bounds = Screen.AllScreens[0].Bounds;
            fsl2.Show();

            fsl.Show();
            lf.Show();
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
            this.Hide();
            Thread t = new Thread(new ThreadStart(openSplash));
            t.Start();
            Thread.Sleep(2000);
            t.Abort();
        }
    }
}
