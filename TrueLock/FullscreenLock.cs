using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TrueLock
{
    public partial class FullscreenLock : Form
    {
        public Form1 Settings = new Form1();
        public FullscreenLock()
        {
            InitializeComponent();
        }

        private void FullscreenLock_Load(object sender, EventArgs e)
        { 
            TextEditorShortcut.Visible = false;
            if (((Form1)Settings).hasEnabledTextEditor)
            {
                TextEditorShortcut.Visible = true;
            }
        }

        private void FullscreenLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void TextEditorShortcut_Click(object sender, EventArgs e)
        {
            TextEditor te = new TextEditor();
            te.Show();
        }

        private void FullscreenLock_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
