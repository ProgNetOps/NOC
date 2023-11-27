using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Seyi.MainUI;

namespace OtherDashboard
{
    public partial class Form1 : Form
    {
        private int minWidth = 60;
        private int maxWidth;
        private Button b;

        public Form1()
        {
            InitializeComponent();
            maxWidth = panelButtons.Width;
            b = Utilities.b;
        }

        private void iconMenu_Click(object sender, EventArgs e)
        {
            Utilities.ToggleMenu(iconMenu, IconChar.Times, IconChar.Bars);
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            Utilities.AnimationLogic(iconMenu, timerMenu, panelSideMenu, panelButtons, minWidth, maxWidth);
        }

        private void iconPower_MouseEnter(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower,-90);
            iconPower.IconColor = Color.Red;
        }

        private void iconPower_MouseLeave(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower);
            iconPower.IconColor = Color.FromArgb(31, 30, 68);
        }

        private void iconPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnMinimize,-10);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnMinimize);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            Utilities.CustomTextBoxBehaviour(txtSearch, SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68), "Type Search Term Here");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            Utilities.CustomTextBoxBehaviour(txtSearch, SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68), "Type Search Term Here");
        }

        private void iconPower_Enter(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower);
            iconPower.IconColor = Color.FromArgb(31, 30, 68);
        }
    }
}
