
namespace NOC
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.linkChangePassword = new System.Windows.Forms.LinkLabel();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.timerAnimateLabel = new System.Windows.Forms.Timer(this.components);
            this.panelRegistration = new System.Windows.Forms.Panel();
            this.cmbContractorList = new System.Windows.Forms.ComboBox();
            this.txtRegConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtRegStaffID = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegPhone = new System.Windows.Forms.TextBox();
            this.txtRegAnswer = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegQuestion = new System.Windows.Forms.TextBox();
            this.txtRegName = new System.Windows.Forms.TextBox();
            this.iconButtonRegistration = new FontAwesome.Sharp.IconButton();
            this.btnRegistration = new FontAwesome.Sharp.IconButton();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape3 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.timerRegistration = new System.Windows.Forms.Timer(this.components);
            this.timerCompleteRegistration = new System.Windows.Forms.Timer(this.components);
            this.linkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new FontAwesome.Sharp.IconButton();
            this.bttnShow = new FontAwesome.Sharp.IconButton();
            this.btnUser = new FontAwesome.Sharp.IconButton();
            this.btnPassword = new FontAwesome.Sharp.IconButton();
            this.iconButtonLogin = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 217);
            this.panel1.TabIndex = 16;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 60;
            this.btnMinimize.Location = new System.Drawing.Point(5, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(55, 39);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 60;
            this.btnClose.Location = new System.Drawing.Point(389, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::NOC.Properties.Resources.glo_small;
            this.pictureBox1.Location = new System.Drawing.Point(123, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Location = new System.Drawing.Point(53, 389);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(332, 26);
            this.txtPassword.TabIndex = 31;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUsername.Location = new System.Drawing.Point(53, 289);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(332, 26);
            this.txtUsername.TabIndex = 30;
            this.txtUsername.Text = "User Name";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(2, 417);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(385, 5);
            this.panel5.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.Location = new System.Drawing.Point(2, 317);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 5);
            this.panel3.TabIndex = 33;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(450, 700);
            this.shapeContainer1.TabIndex = 39;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rectangleShape1.BorderWidth = 5;
            this.rectangleShape1.CornerRadius = 8;
            this.rectangleShape1.Location = new System.Drawing.Point(188, 479);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(199, 51);
            // 
            // linkChangePassword
            // 
            this.linkChangePassword.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkChangePassword.AutoSize = true;
            this.linkChangePassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangePassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkChangePassword.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkChangePassword.Location = new System.Drawing.Point(267, 435);
            this.linkChangePassword.Name = "linkChangePassword";
            this.linkChangePassword.Size = new System.Drawing.Size(123, 16);
            this.linkChangePassword.TabIndex = 40;
            this.linkChangePassword.TabStop = true;
            this.linkChangePassword.Text = "Change Password";
            this.linkChangePassword.Click += new System.EventHandler(this.ModifyPassword);
            // 
            // linkRegistration
            // 
            this.linkRegistration.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkRegistration.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkRegistration.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkRegistration.Location = new System.Drawing.Point(125, 666);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(199, 16);
            this.linkRegistration.TabIndex = 41;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Not Registered? Register Here";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(165, 289);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 25);
            this.lblUsername.TabIndex = 42;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(165, 389);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 25);
            this.lblPassword.TabIndex = 43;
            // 
            // timerAnimateLabel
            // 
            this.timerAnimateLabel.Interval = 1;
            this.timerAnimateLabel.Tick += new System.EventHandler(this.timerAnimateLabel_Tick);
            // 
            // panelRegistration
            // 
            this.panelRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.panelRegistration.Controls.Add(this.cmbContractorList);
            this.panelRegistration.Controls.Add(this.txtRegConfirmPassword);
            this.panelRegistration.Controls.Add(this.txtRegStaffID);
            this.panelRegistration.Controls.Add(this.txtRegPassword);
            this.panelRegistration.Controls.Add(this.txtRegPhone);
            this.panelRegistration.Controls.Add(this.txtRegAnswer);
            this.panelRegistration.Controls.Add(this.txtRegUsername);
            this.panelRegistration.Controls.Add(this.txtRegQuestion);
            this.panelRegistration.Controls.Add(this.txtRegName);
            this.panelRegistration.Controls.Add(this.iconButtonRegistration);
            this.panelRegistration.Controls.Add(this.btnRegistration);
            this.panelRegistration.Controls.Add(this.shapeContainer2);
            this.panelRegistration.Location = new System.Drawing.Point(534, 223);
            this.panelRegistration.Name = "panelRegistration";
            this.panelRegistration.Size = new System.Drawing.Size(446, 481);
            this.panelRegistration.TabIndex = 44;
            // 
            // cmbContractorList
            // 
            this.cmbContractorList.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbContractorList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbContractorList.FormattingEnabled = true;
            this.cmbContractorList.Location = new System.Drawing.Point(30, 349);
            this.cmbContractorList.Name = "cmbContractorList";
            this.cmbContractorList.Size = new System.Drawing.Size(404, 27);
            this.cmbContractorList.TabIndex = 8;
            this.cmbContractorList.Text = "Choose EMC Company Name";
            // 
            // txtRegConfirmPassword
            // 
            this.txtRegConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtRegConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegConfirmPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegConfirmPassword.Location = new System.Drawing.Point(30, 189);
            this.txtRegConfirmPassword.Name = "txtRegConfirmPassword";
            this.txtRegConfirmPassword.Size = new System.Drawing.Size(404, 27);
            this.txtRegConfirmPassword.TabIndex = 4;
            this.txtRegConfirmPassword.TabStop = false;
            this.txtRegConfirmPassword.Tag = "Confirm Password";
            this.txtRegConfirmPassword.Text = "Confirm Password";
            this.txtRegConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegConfirmPassword.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegConfirmPassword.Leave += new System.EventHandler(this.LoseFocus);
            // 
            // txtRegStaffID
            // 
            this.txtRegStaffID.BackColor = System.Drawing.Color.White;
            this.txtRegStaffID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegStaffID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegStaffID.Location = new System.Drawing.Point(30, 309);
            this.txtRegStaffID.Name = "txtRegStaffID";
            this.txtRegStaffID.Size = new System.Drawing.Size(404, 27);
            this.txtRegStaffID.TabIndex = 7;
            this.txtRegStaffID.TabStop = false;
            this.txtRegStaffID.Tag = "Staff ID";
            this.txtRegStaffID.Text = "Staff ID";
            this.txtRegStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegStaffID.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegStaffID.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegStaffID.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.BackColor = System.Drawing.Color.White;
            this.txtRegPassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegPassword.Location = new System.Drawing.Point(30, 149);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(404, 27);
            this.txtRegPassword.TabIndex = 3;
            this.txtRegPassword.TabStop = false;
            this.txtRegPassword.Tag = "Password";
            this.txtRegPassword.Text = "Password";
            this.txtRegPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegPassword.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegPassword.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegPassword.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegPhone
            // 
            this.txtRegPhone.BackColor = System.Drawing.Color.White;
            this.txtRegPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegPhone.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegPhone.Location = new System.Drawing.Point(30, 69);
            this.txtRegPhone.Name = "txtRegPhone";
            this.txtRegPhone.Size = new System.Drawing.Size(404, 27);
            this.txtRegPhone.TabIndex = 1;
            this.txtRegPhone.TabStop = false;
            this.txtRegPhone.Tag = "Phone Number";
            this.txtRegPhone.Text = "Phone Number";
            this.txtRegPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegPhone.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegPhone.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegPhone.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegAnswer
            // 
            this.txtRegAnswer.BackColor = System.Drawing.Color.White;
            this.txtRegAnswer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegAnswer.Location = new System.Drawing.Point(30, 269);
            this.txtRegAnswer.Name = "txtRegAnswer";
            this.txtRegAnswer.Size = new System.Drawing.Size(404, 27);
            this.txtRegAnswer.TabIndex = 6;
            this.txtRegAnswer.TabStop = false;
            this.txtRegAnswer.Tag = "Type The Answer To The Secret Question";
            this.txtRegAnswer.Text = "Type The Answer To The Secret Question";
            this.txtRegAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegAnswer.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegAnswer.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegAnswer.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.BackColor = System.Drawing.Color.White;
            this.txtRegUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegUsername.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegUsername.Location = new System.Drawing.Point(30, 109);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(404, 27);
            this.txtRegUsername.TabIndex = 2;
            this.txtRegUsername.TabStop = false;
            this.txtRegUsername.Tag = "Username";
            this.txtRegUsername.Text = "Username";
            this.txtRegUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegUsername.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegUsername.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegUsername.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegQuestion
            // 
            this.txtRegQuestion.BackColor = System.Drawing.Color.White;
            this.txtRegQuestion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegQuestion.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegQuestion.Location = new System.Drawing.Point(30, 229);
            this.txtRegQuestion.Name = "txtRegQuestion";
            this.txtRegQuestion.Size = new System.Drawing.Size(404, 27);
            this.txtRegQuestion.TabIndex = 5;
            this.txtRegQuestion.TabStop = false;
            this.txtRegQuestion.Tag = "Type A Secret Question";
            this.txtRegQuestion.Text = "Type A Secret Question";
            this.txtRegQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegQuestion.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegQuestion.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegQuestion.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // txtRegName
            // 
            this.txtRegName.BackColor = System.Drawing.Color.White;
            this.txtRegName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegName.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtRegName.Location = new System.Drawing.Point(30, 29);
            this.txtRegName.Name = "txtRegName";
            this.txtRegName.Size = new System.Drawing.Size(404, 27);
            this.txtRegName.TabIndex = 0;
            this.txtRegName.TabStop = false;
            this.txtRegName.Tag = "Name";
            this.txtRegName.Text = "Name";
            this.txtRegName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegName.Enter += new System.EventHandler(this.GetFocus);
            this.txtRegName.Leave += new System.EventHandler(this.LoseFocus);
            this.txtRegName.MouseHover += new System.EventHandler(this.ShowTooltip);
            // 
            // iconButtonRegistration
            // 
            this.iconButtonRegistration.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRegistration.FlatAppearance.BorderSize = 0;
            this.iconButtonRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRegistration.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonRegistration.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButtonRegistration.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRegistration.IconSize = 50;
            this.iconButtonRegistration.Location = new System.Drawing.Point(232, 419);
            this.iconButtonRegistration.Name = "iconButtonRegistration";
            this.iconButtonRegistration.Size = new System.Drawing.Size(91, 46);
            this.iconButtonRegistration.TabIndex = 9;
            this.iconButtonRegistration.TabStop = false;
            this.iconButtonRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRegistration.UseVisualStyleBackColor = false;
            this.iconButtonRegistration.Click += new System.EventHandler(this.CompleteRegistration);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnRegistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistration.FlatAppearance.BorderSize = 0;
            this.btnRegistration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnRegistration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegistration.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistration.IconColor = System.Drawing.SystemColors.Control;
            this.btnRegistration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistration.IconSize = 10;
            this.btnRegistration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.Location = new System.Drawing.Point(311, 419);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(113, 46);
            this.btnRegistration.TabIndex = 10;
            this.btnRegistration.Text = "Sign Up";
            this.btnRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.CompleteRegistration);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape3});
            this.shapeContainer2.Size = new System.Drawing.Size(446, 481);
            this.shapeContainer2.TabIndex = 41;
            this.shapeContainer2.TabStop = false;
            // 
            // rectangleShape3
            // 
            this.rectangleShape3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.rectangleShape3.BorderWidth = 5;
            this.rectangleShape3.CornerRadius = 8;
            this.rectangleShape3.Location = new System.Drawing.Point(227, 416);
            this.rectangleShape3.Name = "rectangleShape3";
            this.rectangleShape3.Size = new System.Drawing.Size(199, 51);
            // 
            // timerRegistration
            // 
            this.timerRegistration.Interval = 1;
            this.timerRegistration.Tick += new System.EventHandler(this.timerRegistration_Tick);
            // 
            // timerCompleteRegistration
            // 
            this.timerCompleteRegistration.Interval = 1;
            this.timerCompleteRegistration.Tick += new System.EventHandler(this.timerCompleteRegistration_Tick);
            // 
            // linkForgotPassword
            // 
            this.linkForgotPassword.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.linkForgotPassword.AutoSize = true;
            this.linkForgotPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkForgotPassword.LinkColor = System.Drawing.Color.DarkGreen;
            this.linkForgotPassword.Location = new System.Drawing.Point(3, 435);
            this.linkForgotPassword.Name = "linkForgotPassword";
            this.linkForgotPassword.Size = new System.Drawing.Size(118, 16);
            this.linkForgotPassword.TabIndex = 40;
            this.linkForgotPassword.TabStop = true;
            this.linkForgotPassword.Text = "Forgot Password?";
            this.linkForgotPassword.Click += new System.EventHandler(this.ModifyPassword);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogin.IconColor = System.Drawing.SystemColors.Control;
            this.btnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogin.IconSize = 10;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(285, 482);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 46);
            this.btnLogin.TabIndex = 38;
            this.btnLogin.Text = "Sign In";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.ValidateDetails);
            // 
            // bttnShow
            // 
            this.bttnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnShow.FlatAppearance.BorderSize = 0;
            this.bttnShow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.bttnShow.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.bttnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnShow.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.bttnShow.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.bttnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bttnShow.IconSize = 40;
            this.bttnShow.Location = new System.Drawing.Point(401, 385);
            this.bttnShow.Name = "bttnShow";
            this.bttnShow.Size = new System.Drawing.Size(42, 27);
            this.bttnShow.TabIndex = 36;
            this.bttnShow.TabStop = false;
            this.bttnShow.UseVisualStyleBackColor = true;
            this.bttnShow.Click += new System.EventHandler(this.bttnShow_Click);
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            this.btnUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUser.IconSize = 60;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUser.Location = new System.Drawing.Point(4, 269);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(50, 45);
            this.btnUser.TabIndex = 32;
            this.btnUser.TabStop = false;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnPassword
            // 
            this.btnPassword.FlatAppearance.BorderSize = 0;
            this.btnPassword.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPassword.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnPassword.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnPassword.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPassword.IconSize = 40;
            this.btnPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPassword.Location = new System.Drawing.Point(4, 378);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(45, 45);
            this.btnPassword.TabIndex = 35;
            this.btnPassword.TabStop = false;
            this.btnPassword.UseVisualStyleBackColor = true;
            // 
            // iconButtonLogin
            // 
            this.iconButtonLogin.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLogin.FlatAppearance.BorderSize = 0;
            this.iconButtonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogin.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonLogin.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconButtonLogin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogin.IconSize = 40;
            this.iconButtonLogin.Location = new System.Drawing.Point(192, 484);
            this.iconButtonLogin.Name = "iconButtonLogin";
            this.iconButtonLogin.Size = new System.Drawing.Size(91, 42);
            this.iconButtonLogin.TabIndex = 37;
            this.iconButtonLogin.TabStop = false;
            this.iconButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogin.UseVisualStyleBackColor = false;
            this.iconButtonLogin.Click += new System.EventHandler(this.ValidateDetails);
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panelRegistration);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.linkChangePassword);
            this.Controls.Add(this.linkRegistration);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.bttnShow);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButtonLogin);
            this.Controls.Add(this.linkForgotPassword);
            this.Controls.Add(this.shapeContainer1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Globacom Network Operations Centre";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRegistration.ResumeLayout(false);
            this.panelRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton bttnShow;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnUser;
        private FontAwesome.Sharp.IconButton btnPassword;
        private FontAwesome.Sharp.IconButton iconButtonLogin;
        private FontAwesome.Sharp.IconButton btnLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.LinkLabel linkChangePassword;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Timer timerAnimateLabel;
        private System.Windows.Forms.Panel panelRegistration;
        private System.Windows.Forms.Timer timerRegistration;
        private FontAwesome.Sharp.IconButton iconButtonRegistration;
        private FontAwesome.Sharp.IconButton btnRegistration;
        private System.Windows.Forms.ComboBox cmbContractorList;
        private System.Windows.Forms.TextBox txtRegConfirmPassword;
        private System.Windows.Forms.TextBox txtRegStaffID;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegPhone;
        private System.Windows.Forms.TextBox txtRegAnswer;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegQuestion;
        private System.Windows.Forms.TextBox txtRegName;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Timer timerCompleteRegistration;
        private System.Windows.Forms.LinkLabel linkForgotPassword;
    }
}

