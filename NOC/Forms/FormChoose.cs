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

namespace NOC
{
    public partial class FormChoose : Form
    {
        public static string userChoice = string.Empty;

        public FormChoose()
        {
            InitializeComponent();
        }       



        private void MakeAChoice(object sender, EventArgs e)
        {
            if (iconButtonCheckEMC.Focused==true)
            {
                iconButtonCheckEMC.IconChar = IconChar.CheckSquare;
                userChoice = "EMC";
            }
            else if (iconButtonCheckGlo.Focused==true)
            {
                iconButtonCheckGlo.IconChar = IconChar.CheckSquare;
                userChoice = "Globacom";
            }
            this.Close();
        }
    }
}
