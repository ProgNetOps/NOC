using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seyi.MainUI;

namespace EMCWindow
{
    public partial class UC_EMC : UserControl
    {
        public UC_EMC()
        {
            InitializeComponent();
			Utilities.CustomGridDisplay(updatesDisplay);

		}

		private void UC_EMC_Load(object sender, EventArgs e)
        {
			int n = 0;
			for (int i = 0; i < 1000; i++)
			{
				n = updatesDisplay.Rows.Add();
				updatesDisplay.Rows[n].Cells[0].Value = "HONT_BSC1";
				updatesDisplay.Rows[n].Cells[1].Value = "ONT027";
				updatesDisplay.Rows[n].Cells[2].Value = "01/Mar/2021 04:09";
				updatesDisplay.Rows[n].Cells[3].Value = "01/Mar/2021 06:54";
				updatesDisplay.Rows[n].Cells[4].Value = "2.56";
				updatesDisplay.Rows[n].Cells[5].Value = "LOSS OF COMPRESSION";
				updatesDisplay.Rows[n].Cells[6].Value = "AMAMBRA";
				n = updatesDisplay.Rows.Add();
				updatesDisplay.Rows[n].Cells[0].Value = "HWAR_BSC1";
				updatesDisplay.Rows[n].Cells[1].Value = "WAR015";
				updatesDisplay.Rows[n].Cells[2].Value = "28/May/2021 12:34";
				updatesDisplay.Rows[n].Cells[3].Value = "29/May/2021 12:39";
				updatesDisplay.Rows[n].Cells[4].Value = "12.73";
				updatesDisplay.Rows[n].Cells[5].Value = "BLOCKED FUEL LINE";
				updatesDisplay.Rows[n].Cells[6].Value = "DELTA";
				n = updatesDisplay.Rows.Add();
				updatesDisplay.Rows[n].Cells[0].Value = "HLAG_BSC4";
				updatesDisplay.Rows[n].Cells[1].Value = "LAG424";
				updatesDisplay.Rows[n].Cells[2].Value = "12/Apr/2021 09:3";
				updatesDisplay.Rows[n].Cells[3].Value = "12/Apr/2021 11:39";
				updatesDisplay.Rows[n].Cells[4].Value = "45,73";
				updatesDisplay.Rows[n].Cells[5].Value = "FAULTY CHARGING ALTERNATOR";
				updatesDisplay.Rows[n].Cells[6].Value = "LAGOS";
				n = updatesDisplay.Rows.Add();
				updatesDisplay.Rows[n].Cells[0].Value = "ZASA_BSC1";
				updatesDisplay.Rows[n].Cells[1].Value = "ASA025";
				updatesDisplay.Rows[n].Cells[2].Value = "10/Jan/2021 09:3";
				updatesDisplay.Rows[n].Cells[3].Value = "12/Jan/2021 09:3";
				updatesDisplay.Rows[n].Cells[4].Value = "34.98";
				updatesDisplay.Rows[n].Cells[5].Value = "LOW ALT VOLT";
				updatesDisplay.Rows[n].Cells[6].Value = "DELTA";
			}
		}

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
