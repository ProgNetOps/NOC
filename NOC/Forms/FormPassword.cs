using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOC
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        public FormPassword(LinkLabel lbl):this()
        {
            if (lbl.Text== "Change Password")
            {
                txtPwdOldPassword.Visible = txtPwdNewPassword.Visible = txtPwdConfirmPassword.Visible = true;
                txtPwdQuestion.Visible = txtPwdAnswer.Visible = txtPwdPhone.Visible = false;
            }
            else if (lbl.Text=="Forgot Password?")
            {
                txtPwdOldPassword.Visible = txtPwdNewPassword.Visible = txtPwdConfirmPassword.Visible = false;
                txtPwdQuestion.Visible = txtPwdAnswer.Visible = txtPwdPhone.Visible = true;
            }
        }

        private void GetFocus(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).Clear();
        }

        private void LoseFocus(object sender, EventArgs e)
        {
            (sender as TextBox).ForeColor = SystemColors.ActiveCaption;
            (sender as TextBox).Text = TextboxText(sender as TextBox);
        }

        private string TextboxText(TextBox txt)
        {
            if (txt == txtPwdPhone)
            {
                return "Phone Number";
            }
            else if (txt == txtPwdQuestion)
            {
                return "Secret Question";
            }
            else if (txt == txtPwdAnswer)
            {
                return "Answer To The Secret Question";
            }
            
            else if (txt == txtPwdOldPassword)
            {
                return "Old Password";
            }
            else if (txt == txtPwdNewPassword)
            {
                return "New Password";
            }
            else if (txt == txtPwdConfirmPassword)
            {
                return "Confirm New Password";
            }
            
            
            return string.Empty;
        }
    }
}
