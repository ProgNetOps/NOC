
namespace NOC
{
    partial class FormPassword
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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtPwdConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtPwdNewPassword = new System.Windows.Forms.TextBox();
            this.txtPwdPhone = new System.Windows.Forms.TextBox();
            this.txtPwdAnswer = new System.Windows.Forms.TextBox();
            this.txtPwdQuestion = new System.Windows.Forms.TextBox();
            this.txtPwdOldPassword = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(330, 330);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.DarkGreen;
            this.rectangleShape1.BorderWidth = 10;
            this.rectangleShape1.CornerRadius = 20;
            this.rectangleShape1.FillColor = System.Drawing.SystemColors.Control;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(11, 21);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(307, 288);
            // 
            // txtPwdConfirmPassword
            // 
            this.txtPwdConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtPwdConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdConfirmPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdConfirmPassword.Location = new System.Drawing.Point(24, 212);
            this.txtPwdConfirmPassword.Name = "txtPwdConfirmPassword";
            this.txtPwdConfirmPassword.Size = new System.Drawing.Size(283, 27);
            this.txtPwdConfirmPassword.TabIndex = 9;
            this.txtPwdConfirmPassword.TabStop = false;
            this.txtPwdConfirmPassword.Text = "Confirm New Password";
            this.txtPwdConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdConfirmPassword.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdConfirmPassword.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtPwdNewPassword
            // 
            this.txtPwdNewPassword.BackColor = System.Drawing.Color.White;
            this.txtPwdNewPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdNewPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdNewPassword.Location = new System.Drawing.Point(24, 178);
            this.txtPwdNewPassword.Name = "txtPwdNewPassword";
            this.txtPwdNewPassword.Size = new System.Drawing.Size(283, 27);
            this.txtPwdNewPassword.TabIndex = 8;
            this.txtPwdNewPassword.TabStop = false;
            this.txtPwdNewPassword.Text = "New Password";
            this.txtPwdNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdNewPassword.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdNewPassword.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtPwdPhone
            // 
            this.txtPwdPhone.BackColor = System.Drawing.Color.White;
            this.txtPwdPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdPhone.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdPhone.Location = new System.Drawing.Point(24, 42);
            this.txtPwdPhone.Name = "txtPwdPhone";
            this.txtPwdPhone.Size = new System.Drawing.Size(283, 27);
            this.txtPwdPhone.TabIndex = 7;
            this.txtPwdPhone.TabStop = false;
            this.txtPwdPhone.Text = "Phone Number";
            this.txtPwdPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdPhone.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdPhone.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtPwdAnswer
            // 
            this.txtPwdAnswer.BackColor = System.Drawing.Color.White;
            this.txtPwdAnswer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdAnswer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdAnswer.Location = new System.Drawing.Point(24, 110);
            this.txtPwdAnswer.Name = "txtPwdAnswer";
            this.txtPwdAnswer.Size = new System.Drawing.Size(283, 27);
            this.txtPwdAnswer.TabIndex = 11;
            this.txtPwdAnswer.TabStop = false;
            this.txtPwdAnswer.Text = "Answer To The Secret Question";
            this.txtPwdAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdAnswer.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdAnswer.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtPwdQuestion
            // 
            this.txtPwdQuestion.BackColor = System.Drawing.Color.White;
            this.txtPwdQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdQuestion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdQuestion.Location = new System.Drawing.Point(24, 76);
            this.txtPwdQuestion.Name = "txtPwdQuestion";
            this.txtPwdQuestion.Size = new System.Drawing.Size(283, 27);
            this.txtPwdQuestion.TabIndex = 10;
            this.txtPwdQuestion.TabStop = false;
            this.txtPwdQuestion.Text = "Secret Question";
            this.txtPwdQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdQuestion.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdQuestion.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtPwdOldPassword
            // 
            this.txtPwdOldPassword.BackColor = System.Drawing.Color.White;
            this.txtPwdOldPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwdOldPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPwdOldPassword.Location = new System.Drawing.Point(24, 144);
            this.txtPwdOldPassword.Name = "txtPwdOldPassword";
            this.txtPwdOldPassword.Size = new System.Drawing.Size(283, 27);
            this.txtPwdOldPassword.TabIndex = 8;
            this.txtPwdOldPassword.TabStop = false;
            this.txtPwdOldPassword.Text = "Old Password";
            this.txtPwdOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPwdOldPassword.Enter += new System.EventHandler(this.GetFocus);
            this.txtPwdOldPassword.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.iconButton1.FlatAppearance.BorderSize = 3;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(115, 252);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(100, 46);
            this.iconButton1.TabIndex = 12;
            this.iconButton1.Text = "OK";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.shapeContainer1;
            // 
            // FormPassword
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(330, 330);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.txtPwdOldPassword);
            this.Controls.Add(this.txtPwdConfirmPassword);
            this.Controls.Add(this.txtPwdNewPassword);
            this.Controls.Add(this.txtPwdPhone);
            this.Controls.Add(this.txtPwdAnswer);
            this.Controls.Add(this.txtPwdQuestion);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPassword";
            this.ShowInTaskbar = false;
            this.Text = "FormPassword";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.TextBox txtPwdConfirmPassword;
        private System.Windows.Forms.TextBox txtPwdNewPassword;
        private System.Windows.Forms.TextBox txtPwdPhone;
        private System.Windows.Forms.TextBox txtPwdAnswer;
        private System.Windows.Forms.TextBox txtPwdQuestion;
        private System.Windows.Forms.TextBox txtPwdOldPassword;
        private FontAwesome.Sharp.IconButton iconButton1;
        private DragControlDemo.DragControl dragControl1;
    }
}