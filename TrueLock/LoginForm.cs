using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Input;
using TrueLock.Util;
using TrueLock.Security;

namespace TrueLock
{
    public partial class LoginForm : Form
    {
        public Form1 Settings = new Form1();
        public string Username, Password;
        public bool enabledShutdown;
        public DisableKeys DisableKeys = new DisableKeys();

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This PC is locked by the owner. please contact the owner to gain access to this PC or give the login details.", "TrueLock Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.enabledShutdown = ((Form1)Settings).hasEnabledShutdown;
            this.Username = ((Form1)Settings).Username;
            this.Password = ((Form1)Settings).Password;
            this.BringToFront();

            if (!enabledShutdown)
            {
                ShutdownButton.Visible = false;
            }
            
        }

        private void ShutdownButton_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("Do you really want to Shutdown this PC?", "TrueLock Warning", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Helpers.ExecuteCommand("shutdown /p");
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.Modifiers == Keys.Tab || e.Modifiers == Keys.LWin || e.Modifiers == Keys.Escape || e.Modifiers == Keys.Alt && e.Modifiers == Keys.LWin || e.Modifiers == Keys.Control && e.Modifiers == Keys.Alt && e.Modifiers == Keys.Delete)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == Settings.Username && PasswordTextBox.Text == Settings.Password)
            {
                Helpers.ExecuteCommand("start explorer.exe");
                Environment.Exit(0);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        public LoginForm()
        {
            InitializeComponent();
        }
    }
}
