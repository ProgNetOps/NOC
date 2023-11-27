using Seyi.MainUI;
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
using EMCWindow;

namespace MainDashboard
{
    public partial class Form1 : Form
    {

        private List<Panel> collectionOfControls = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.DoubleBuffered = true;
            Utilities.minWidth = 60;
            Utilities.maxWidth = 210;
            collectionOfControls.AddRange(new List<Panel>() { panel2, panel3, panel4, panel5, panel6, panel9, panel12 });
            Utilities.listOfInnerContainers = collectionOfControls;
        }

       
        private void iconMenu_Click(object sender, EventArgs e)
        {
            Utilities.ToggleMenu(iconMenu, IconChar.Times, IconChar.Bars);
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            Utilities.AnimationLogic(iconMenu, timerMenu, panelSideMenu, Utilities.listOfInnerContainers, Utilities.minWidth, Utilities.maxWidth);
        }

        private void timerDistender_Tick(object sender, EventArgs e)
        {
            Utilities.ControlsDistender(Utilities.b, timerDistender);
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnSim;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();

        }

        private void iconButton29_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnEscalations;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();
        }

        private void BtnTrans_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnSummaries;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();
        }

        private void iconPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPower_MouseEnter_1(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower, -90);
            iconPower.IconColor = Color.Red;
        }

        private void iconPower_MouseLeave_1(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower);
            iconPower.IconColor = Color.FromArgb(31, 30, 68);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnMinimize, -10);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnMinimize);
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnReports;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();
        }

        private void BtnAdminPlus_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnAdminPlus;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            Utilities.b = BtnAdmin;
            Utilities.Resetter(Utilities.b);
            timerDistender.Start();
        }

        
        private void BtnSettings_Click(object sender, EventArgs e)
        {

        }


        private void txtSearch_Enter(object sender, EventArgs e)
        {
            Utilities.CustomTextBoxBehaviour(txtSearch, SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68),"Type Search Term Here");
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            Utilities.CustomTextBoxBehaviour(txtSearch, SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68), "Type Search Term Here");
        }

        private void iconPower_MouseDown(object sender, MouseEventArgs e)
        {
            Utilities.RotateButtonOnHover(iconPower);
            iconPower.IconColor = Color.FromArgb(31, 30, 68);
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

        private void btnUpdates_Click(object sender, EventArgs e)
        {
            UC_EMC emcUpdates = new UC_EMC();
            Utilities.AddControlsToPanel(emcUpdates, panelControls);
        }
    }
}
