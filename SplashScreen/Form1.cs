using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Seyi.Login;

namespace SplashScreen
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            CustomTools.AnimateWindow(this.Handle, 2000, CustomTools.VERTICAL_FROMTOP);
            CustomTools.myProgressBar(this.panelMain, this.panelSecondary, this.panelSlide, this.timer1);
        }
    }
}
