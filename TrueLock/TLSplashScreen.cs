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
    public partial class TLSplashScreen : Form
    {
        public TLSplashScreen()
        {
            InitializeComponent();
        }

        private void TLSplashScreen_Load(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
