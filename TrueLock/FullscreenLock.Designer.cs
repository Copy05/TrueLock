namespace TrueLock
{
    partial class FullscreenLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FullscreenLock));
            this.TextEditorShortcut = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditorShortcut)).BeginInit();
            this.SuspendLayout();
            // 
            // TextEditorShortcut
            // 
            this.TextEditorShortcut.Image = global::TrueLock.Properties.Resources.note_2_64;
            this.TextEditorShortcut.Location = new System.Drawing.Point(44, 40);
            this.TextEditorShortcut.Name = "TextEditorShortcut";
            this.TextEditorShortcut.Size = new System.Drawing.Size(64, 64);
            this.TextEditorShortcut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TextEditorShortcut.TabIndex = 1;
            this.TextEditorShortcut.TabStop = false;
            this.TextEditorShortcut.Click += new System.EventHandler(this.TextEditorShortcut_Click);
            // 
            // FullscreenLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextEditorShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FullscreenLock";
            this.Text = "FullscreenLock";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FullscreenLock_FormClosing);
            this.Load += new System.EventHandler(this.FullscreenLock_Load);
            this.Resize += new System.EventHandler(this.FullscreenLock_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditorShortcut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox TextEditorShortcut;
    }
}