
namespace NOC
{
    partial class FormChoose
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
            this.ovalShape1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.iconButtonCheckGlo = new FontAwesome.Sharp.IconButton();
            this.iconButtonCheckEMC = new FontAwesome.Sharp.IconButton();
            this.dragControl1 = new DragControlDemo.DragControl();
            this.SuspendLayout();
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(335, 319);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape1
            // 
            this.ovalShape1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ovalShape1.BorderColor = System.Drawing.Color.DarkGreen;
            this.ovalShape1.BorderWidth = 10;
            this.ovalShape1.FillColor = System.Drawing.SystemColors.Control;
            this.ovalShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape1.Location = new System.Drawing.Point(33, 25);
            this.ovalShape1.Name = "ovalShape1";
            this.ovalShape1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ovalShape1.Size = new System.Drawing.Size(270, 270);
            // 
            // iconButtonCheckGlo
            // 
            this.iconButtonCheckGlo.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckGlo.FlatAppearance.BorderSize = 0;
            this.iconButtonCheckGlo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckGlo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckGlo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCheckGlo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCheckGlo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonCheckGlo.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.iconButtonCheckGlo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonCheckGlo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCheckGlo.IconSize = 60;
            this.iconButtonCheckGlo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCheckGlo.Location = new System.Drawing.Point(73, 164);
            this.iconButtonCheckGlo.Name = "iconButtonCheckGlo";
            this.iconButtonCheckGlo.Size = new System.Drawing.Size(191, 55);
            this.iconButtonCheckGlo.TabIndex = 1;
            this.iconButtonCheckGlo.TabStop = false;
            this.iconButtonCheckGlo.Text = "Globacom";
            this.iconButtonCheckGlo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCheckGlo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCheckGlo.UseVisualStyleBackColor = false;
            this.iconButtonCheckGlo.Enter += new System.EventHandler(this.MakeAChoice);
            // 
            // iconButtonCheckEMC
            // 
            this.iconButtonCheckEMC.BackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckEMC.FlatAppearance.BorderSize = 0;
            this.iconButtonCheckEMC.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckEMC.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.iconButtonCheckEMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCheckEMC.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCheckEMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonCheckEMC.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.iconButtonCheckEMC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconButtonCheckEMC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCheckEMC.IconSize = 60;
            this.iconButtonCheckEMC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCheckEMC.Location = new System.Drawing.Point(73, 99);
            this.iconButtonCheckEMC.Name = "iconButtonCheckEMC";
            this.iconButtonCheckEMC.Size = new System.Drawing.Size(147, 55);
            this.iconButtonCheckEMC.TabIndex = 0;
            this.iconButtonCheckEMC.TabStop = false;
            this.iconButtonCheckEMC.Tag = "";
            this.iconButtonCheckEMC.Text = "EMC";
            this.iconButtonCheckEMC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCheckEMC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCheckEMC.UseVisualStyleBackColor = false;
            this.iconButtonCheckEMC.Enter += new System.EventHandler(this.MakeAChoice);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.shapeContainer1;
            // 
            // FormChoose
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(335, 319);
            this.Controls.Add(this.iconButtonCheckGlo);
            this.Controls.Add(this.iconButtonCheckEMC);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormChoose";
            this.ShowInTaskbar = false;
            this.Tag = "";
            this.Text = "FormChoose";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonCheckEMC;
        private FontAwesome.Sharp.IconButton iconButtonCheckGlo;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape1;
        private DragControlDemo.DragControl dragControl1;
    }
}