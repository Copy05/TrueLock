namespace TrueLock
{
    partial class FullWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullWebBrowser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.goBackBtn = new System.Windows.Forms.Button();
            this.goForwardBtn = new System.Windows.Forms.Button();
            this.LoginArea = new System.Windows.Forms.Panel();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.HelpButton = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.BrowserFrame = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.LoginArea.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.refreshBtn);
            this.panel1.Controls.Add(this.goBackBtn);
            this.panel1.Controls.Add(this.goForwardBtn);
            this.panel1.Controls.Add(this.LoginArea);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 74);
            this.panel1.TabIndex = 0;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackgroundImage = global::TrueLock.Properties.Resources.refresh_2_64;
            this.refreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Location = new System.Drawing.Point(145, 12);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(47, 47);
            this.refreshBtn.TabIndex = 13;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // goBackBtn
            // 
            this.goBackBtn.BackgroundImage = global::TrueLock.Properties.Resources.arrow_88_64;
            this.goBackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goBackBtn.FlatAppearance.BorderSize = 0;
            this.goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBackBtn.Location = new System.Drawing.Point(12, 10);
            this.goBackBtn.Name = "goBackBtn";
            this.goBackBtn.Size = new System.Drawing.Size(48, 49);
            this.goBackBtn.TabIndex = 12;
            this.goBackBtn.UseVisualStyleBackColor = true;
            this.goBackBtn.Click += new System.EventHandler(this.goBackBtn_Click);
            // 
            // goForwardBtn
            // 
            this.goForwardBtn.BackgroundImage = global::TrueLock.Properties.Resources.arrow_24_64;
            this.goForwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.goForwardBtn.FlatAppearance.BorderSize = 0;
            this.goForwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goForwardBtn.Location = new System.Drawing.Point(83, 11);
            this.goForwardBtn.Name = "goForwardBtn";
            this.goForwardBtn.Size = new System.Drawing.Size(45, 47);
            this.goForwardBtn.TabIndex = 3;
            this.goForwardBtn.UseVisualStyleBackColor = true;
            this.goForwardBtn.Click += new System.EventHandler(this.goForwardBtn_Click);
            // 
            // LoginArea
            // 
            this.LoginArea.Controls.Add(this.UsernameTextBox);
            this.LoginArea.Controls.Add(this.HelpButton);
            this.LoginArea.Controls.Add(this.EnterBtn);
            this.LoginArea.Controls.Add(this.label2);
            this.LoginArea.Controls.Add(this.PasswordTextBox);
            this.LoginArea.Controls.Add(this.label1);
            this.LoginArea.Location = new System.Drawing.Point(311, 5);
            this.LoginArea.Name = "LoginArea";
            this.LoginArea.Size = new System.Drawing.Size(541, 63);
            this.LoginArea.TabIndex = 11;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(74, 3);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(276, 20);
            this.UsernameTextBox.TabIndex = 5;
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(448, 16);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(75, 26);
            this.HelpButton.TabIndex = 9;
            this.HelpButton.Text = "Help";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(365, 16);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(77, 26);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "&Password:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(74, 29);
            this.PasswordTextBox.MaxLength = 14;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(276, 20);
            this.PasswordTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "&Login:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(13, 21);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(96, 26);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Show Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // BrowserFrame
            // 
            this.BrowserFrame.AllowWebBrowserDrop = false;
            this.BrowserFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserFrame.IsWebBrowserContextMenuEnabled = false;
            this.BrowserFrame.Location = new System.Drawing.Point(0, 74);
            this.BrowserFrame.MinimumSize = new System.Drawing.Size(20, 20);
            this.BrowserFrame.Name = "BrowserFrame";
            this.BrowserFrame.ScriptErrorsSuppressed = true;
            this.BrowserFrame.Size = new System.Drawing.Size(1105, 376);
            this.BrowserFrame.TabIndex = 2;
            this.BrowserFrame.TabStop = false;
            this.BrowserFrame.WebBrowserShortcutsEnabled = false;
            this.BrowserFrame.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.BrowserFrame_Navigating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(918, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 74);
            this.panel2.TabIndex = 14;
            // 
            // FullWebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.ControlBox = false;
            this.Controls.Add(this.BrowserFrame);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FullWebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FullWebBrowser";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FullWebBrowser_Load);
            this.panel1.ResumeLayout(false);
            this.LoginArea.ResumeLayout(false);
            this.LoginArea.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Panel LoginArea;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.WebBrowser BrowserFrame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button goBackBtn;
        private System.Windows.Forms.Button goForwardBtn;
        private System.Windows.Forms.Panel panel2;
    }
}