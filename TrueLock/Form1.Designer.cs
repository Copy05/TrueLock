namespace TrueLock
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.URLGB = new System.Windows.Forms.GroupBox();
            this.URLTB = new System.Windows.Forms.TextBox();
            this.WebBrowserCB = new System.Windows.Forms.CheckBox();
            this.KillAppsCB = new System.Windows.Forms.CheckBox();
            this.ShutdownCB = new System.Windows.Forms.CheckBox();
            this.enableTECB = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LockButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.URLGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "TrueLock";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.PasswordTextBox);
            this.groupBox1.Controls.Add(this.UsernameTextBox);
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Login";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(77, 56);
            this.PasswordTextBox.MaxLength = 14;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(341, 20);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(77, 30);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(341, 20);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(343, 81);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.URLGB);
            this.groupBox2.Controls.Add(this.WebBrowserCB);
            this.groupBox2.Controls.Add(this.KillAppsCB);
            this.groupBox2.Controls.Add(this.ShutdownCB);
            this.groupBox2.Controls.Add(this.enableTECB);
            this.groupBox2.Location = new System.Drawing.Point(12, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(424, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Optional Settings";
            // 
            // URLGB
            // 
            this.URLGB.Controls.Add(this.URLTB);
            this.URLGB.Location = new System.Drawing.Point(198, 45);
            this.URLGB.Name = "URLGB";
            this.URLGB.Size = new System.Drawing.Size(220, 49);
            this.URLGB.TabIndex = 5;
            this.URLGB.TabStop = false;
            this.URLGB.Text = "URL";
            // 
            // URLTB
            // 
            this.URLTB.Location = new System.Drawing.Point(6, 18);
            this.URLTB.Name = "URLTB";
            this.URLTB.Size = new System.Drawing.Size(208, 20);
            this.URLTB.TabIndex = 5;
            this.URLTB.TextChanged += new System.EventHandler(this.URLTB_TextChanged);
            // 
            // WebBrowserCB
            // 
            this.WebBrowserCB.AutoSize = true;
            this.WebBrowserCB.Location = new System.Drawing.Point(198, 22);
            this.WebBrowserCB.Name = "WebBrowserCB";
            this.WebBrowserCB.Size = new System.Drawing.Size(130, 17);
            this.WebBrowserCB.TabIndex = 4;
            this.WebBrowserCB.Text = "Open as WebBrowser";
            this.WebBrowserCB.UseVisualStyleBackColor = true;
            this.WebBrowserCB.CheckedChanged += new System.EventHandler(this.WebBrowserCB_CheckedChanged);
            // 
            // KillAppsCB
            // 
            this.KillAppsCB.AutoSize = true;
            this.KillAppsCB.Location = new System.Drawing.Point(21, 68);
            this.KillAppsCB.Name = "KillAppsCB";
            this.KillAppsCB.Size = new System.Drawing.Size(110, 17);
            this.KillAppsCB.TabIndex = 3;
            this.KillAppsCB.Text = "Kill Mostly of apps";
            this.KillAppsCB.UseVisualStyleBackColor = true;
            this.KillAppsCB.CheckedChanged += new System.EventHandler(this.KillAppsCB_CheckedChanged);
            // 
            // ShutdownCB
            // 
            this.ShutdownCB.AutoSize = true;
            this.ShutdownCB.Location = new System.Drawing.Point(21, 45);
            this.ShutdownCB.Name = "ShutdownCB";
            this.ShutdownCB.Size = new System.Drawing.Size(144, 17);
            this.ShutdownCB.TabIndex = 2;
            this.ShutdownCB.Text = "Enable Shutdown Button";
            this.ShutdownCB.UseVisualStyleBackColor = true;
            this.ShutdownCB.CheckedChanged += new System.EventHandler(this.ShutdownCB_CheckedChanged);
            // 
            // enableTECB
            // 
            this.enableTECB.AutoSize = true;
            this.enableTECB.Location = new System.Drawing.Point(21, 22);
            this.enableTECB.Name = "enableTECB";
            this.enableTECB.Size = new System.Drawing.Size(109, 17);
            this.enableTECB.TabIndex = 1;
            this.enableTECB.Text = "Enable Texteditor";
            this.enableTECB.UseVisualStyleBackColor = true;
            this.enableTECB.CheckedChanged += new System.EventHandler(this.enableTECB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(c) Copyright Copy05 2016-2022";
            // 
            // LockButton
            // 
            this.LockButton.Enabled = false;
            this.LockButton.Location = new System.Drawing.Point(361, 316);
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(75, 23);
            this.LockButton.TabIndex = 4;
            this.LockButton.Text = "Lock";
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 353);
            this.Controls.Add(this.LockButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 392);
            this.MinimumSize = new System.Drawing.Size(460, 392);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrueLock v1.0 Configurations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.URLGB.ResumeLayout(false);
            this.URLGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LockButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.CheckBox enableTECB;
        private System.Windows.Forms.CheckBox ShutdownCB;
        private System.Windows.Forms.CheckBox KillAppsCB;
        private System.Windows.Forms.CheckBox WebBrowserCB;
        private System.Windows.Forms.GroupBox URLGB;
        private System.Windows.Forms.TextBox URLTB;
    }
}

