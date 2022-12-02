/*
 * 
 * Copyright Copy05 2016-2023
 * TrueLock is a product by Copy05.
 * 
 * **/

using System;
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
