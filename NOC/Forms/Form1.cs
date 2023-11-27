using Seyi.Login;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Seyi.ModalDialogs;
using Seyi.MainUI;


namespace NOC
{
    public partial class FormLogin : Form
    {
        int elevation = 0;
        string levelU = "down";
        string levelP = "down";

        public FormLogin()
        {
            InitializeComponent();
        }

        
        private void txtUsername_Enter(object sender, EventArgs e)
        {
            UsernameInput();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            PasswordInput();
        }

        private void timerAnimateLabel_Tick(object sender, EventArgs e)
        {
            if (txtUsername.Text == string.Empty && levelU == "down" )
            {
                iconButtonLogin.Enabled = btnLogin.Enabled = txtUsername.Enabled = txtPassword.Enabled = false;
                elevation+=5;
                lblUsername.Top -= 5;
                if (elevation == 50)
                {
                    elevation = 0;
                    levelU = "up";
                    timerAnimateLabel.Stop();
                    iconButtonLogin.Enabled = btnLogin.Enabled = txtUsername.Enabled = txtPassword.Enabled = true;
                    txtUsername.Focus();
                }
            }
            else if (txtPassword.Text == string.Empty && levelP == "down" )
            {
                iconButtonLogin.Enabled = btnLogin.Enabled = txtUsername.Enabled = txtPassword.Enabled = false;
                elevation+=5;
                lblPassword.Top -= 5;
                if (elevation == 50)
                {
                    elevation = 0;
                    levelP = "up";
                    timerAnimateLabel.Stop();
                    iconButtonLogin.Enabled = btnLogin.Enabled = txtUsername.Enabled = txtPassword.Enabled = true;
                    txtPassword.Focus();
                }
            }

            else if (levelU == "up" && levelP == "up")
            {
                txtUsername.Enabled = txtPassword.Enabled = false;
                elevation+=5;
                lblUsername.Top += 5;
                lblPassword.Top += 5;
                if (elevation == 5)
                {
                   iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Unlock;
                   iconButtonLogin.IconColor = Color.Green;

                    btnUser.IconColor = btnPassword.IconColor = Color.FromArgb(31, 30, 68);                    
                }

                if (elevation == 50)
                {
                    txtUsername.Enabled = txtPassword.Enabled = true;
                    elevation = 0;
                    txtUsername.Text = "User Name";
                    txtPassword.Text = "Password";

                    txtUsername.ForeColor = txtPassword.ForeColor = SystemColors.InactiveCaption;
                    lblUsername.Text = lblPassword.Text = string.Empty;

                    iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
                    iconButtonLogin.IconColor = Color.FromArgb(31, 30, 68);

                    levelU = levelP = "down";

                    timerAnimateLabel.Stop();
                   
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnClose, -90);
            btnClose.IconColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Utilities.RotateButtonOnHover(btnClose);
            btnClose.IconColor = SystemColors.Control;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.IconColor = Color.DarkGreen;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.IconColor = SystemColors.Control;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bttnShow_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility();
        }


        #region //Methods for Login Form

        private void UsernameInput()
        {
            if (txtUsername.Text == "User Name" && txtUsername.Focus())
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.DarkGreen;
                lblUsername.Text = "User Name";
                lblUsername.ForeColor = Color.FromArgb(31, 30, 68);
                btnUser.IconColor = Color.DarkGreen;
                timerAnimateLabel.Start();
            }
        }

        private void PasswordInput()
        {
            if (txtPassword.Focus() && txtPassword.Text == "Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.DarkGreen;
                lblPassword.Text = "Password";
                lblPassword.ForeColor = Color.FromArgb(31, 30, 68);
                btnPassword.IconColor = Color.DarkGreen;
                txtPassword.UseSystemPasswordChar = true;
                bttnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
                timerAnimateLabel.Start();
            }
        }


        private void TogglePasswordVisibility()
        {
            if (bttnShow.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                txtPassword.UseSystemPasswordChar = false;
                bttnShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            }
            else if (bttnShow.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                txtPassword.UseSystemPasswordChar = true;
                bttnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            txtPassword.Focus();
        }


        #endregion
    

        private void ValidateDetails(object sender, EventArgs e)
        {
            timerAnimateLabel.Start();
        }

        
        private void linkRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomDialog.PopWithFadeBackground(this, new FormChoose());
            timerRegistration.Start();
        }

        private void ModifyPassword(object sender, EventArgs e)
        {
            //Call the overloaded constructor of the frmpassword class that takes a linklabel argument
            CustomDialog.PopWithFadeBackground(this, new FormPassword(sender as LinkLabel));
        }

        private void GetTagValue()
        {
            string choice = FormChoose.userChoice;


            if (choice == "EMC")
            {
                txtRegStaffID.Visible = false;
                cmbContractorList.Location = txtRegStaffID.Location;
                cmbContractorList.Visible = true;
            }
            else if (choice == "Globacom")
            {
                cmbContractorList.Visible = false;
                txtRegStaffID.Visible = true;
            }
        }

        private void timerRegistration_Tick(object sender, EventArgs e)
        {
            while (panelRegistration.Left > 2)
            {
                panelRegistration.Left-=20;
            }
            GetTagValue();
            timerRegistration.Stop();
        }

        
        private string TipValues(TextBox txt)
        {
            if (txt==txtRegAnswer)
            {
                return "This answer will be required to recover your\npassword if you forget your password.";
            }
            else if (txt==txtRegPassword)
            {
                return "This password will be required before\nyou are allowed to sign in.";
            }
            else if (txt==txtRegName)
            {
                return "Your firstname or lastname or both";
            }
            else if (txt==txtRegPhone)
            {
                return "GLO STAFF: staff phone number\nEMC: any mobile phone number";
            }
            else if (txt==txtRegQuestion)
            {
                return "This question will be required to recover your\npassword if you forget your password";
            }
            else if (txt==txtRegStaffID)
            {
                return "The six-digit Glo staff ID";
            }
            else if (txt==txtRegUsername)
            {
                return "This username will be required before\nyou are allowed to sign in.";
            }
            return string.Empty;
        }

        private void GetFocus(object sender, EventArgs e)
        {
            string theTextContent = (sender as TextBox).Tag.ToString();
            Utilities.CustomTextBoxBehaviour((sender as TextBox), SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68), theTextContent);
        }

        private void LoseFocus(object sender, EventArgs e)
        {
            string theTextContent = (sender as TextBox).Tag.ToString();
            Utilities.CustomTextBoxBehaviour((sender as TextBox), SystemColors.InactiveCaption, Color.FromArgb(31, 30, 68), theTextContent);
        }

    private string TextboxText(TextBox txt)
        {
            if (txt == txtRegAnswer)
            {
                return "Type The Answer To The Secret Question";
            }
            else if (txt == txtRegPassword)
            {
                return "Password";
            }
            else if (txt == txtRegName)
            {
                return "Name";
            }
            else if (txt == txtRegPhone)
            {
                return "Phone Number";
            }
            else if (txt == txtRegQuestion)
            {
                return "Type A Secret Question";
            }
            else if (txt == txtRegStaffID)
            {
                return "Staff ID";
            }
            else if (txt == txtRegUsername)
            {
                return "Username";
            }
            else if (txt == txtRegConfirmPassword)
            {
                return "Confirm Password";
            }
            return string.Empty;
        }

        private void ShowTooltip(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.InitialDelay = 0;
            tip.SetToolTip(sender as TextBox, TipValues(sender as TextBox));
        }

        private void CompleteRegistration(object sender, EventArgs e)
        {
            timerCompleteRegistration.Start();
            txtUsername.Focus();
        }

        private void timerCompleteRegistration_Tick(object sender, EventArgs e)
        {
            while (panelRegistration.Left < 500)
            {
                panelRegistration.Left += 20;
            }
            timerCompleteRegistration.Stop();
        }
    }

    
}
