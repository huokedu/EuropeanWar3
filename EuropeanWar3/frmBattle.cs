using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuropeanWar3Library;

namespace EuropeanWar3
{
    public partial class frmBattle : Form
    {
        private Battle battle;

        public frmBattle(Battle battle)
        {
            InitializeComponent();
            this.battle = battle;
            txtMap.Text = battle.map.ToString();
            txtBattleName.Text = battle.battleName;
        }

        private void btnSaveBattle_Click(object sender, EventArgs e)
        {

            battle.map = int.Parse(txtMap.Text);
            battle.battleName = txtBattleName.Text;
            MessageBox.Show("儲存設定成功。", "歐三戰役編輯器",
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void frmBattle_Load(object sender, EventArgs e)
        {

        }
    }
}
