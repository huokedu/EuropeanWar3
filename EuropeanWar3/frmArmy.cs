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
    public partial class frmArmy : Form
    {
        private Battle battle;
        private Army army;
        private int tempID = -1;

        public frmArmy(Battle battle)
        {
            InitializeComponent();
            this.battle = battle;
            army = new Army();
            foreach (Area area in battle.areaList)
            {
                cboArmyID.Items.Add(area.id);
            }
            for (int i = 0; i <= (int)Army.MAX_LEVEL; i++)
            {
                cboArmyLevel.Items.Add(i.ToString());
            }
        }

        public frmArmy(Battle battle, int id)
        {
            InitializeComponent();
            this.battle = battle;
            army = new Army();
            cboArmyID.Text = id.ToString();
            foreach (Area area in battle.areaList)
            {
                cboArmyID.Items.Add(area.id);
            }
            for (int i = 0; i <= (int)Army.MAX_LEVEL; i++)
            {
                cboArmyLevel.Items.Add(i.ToString());
            }
        }

        public frmArmy(Battle battle, Army army, int id)
        {
            InitializeComponent();
            this.battle = battle;
            this.army = army;
            tempID = id;
            foreach (Area area in battle.areaList)
            {
                cboArmyID.Items.Add(area.id);
            }
            for (int i = 0; i <= (int)Army.MAX_LEVEL; i++)
            {
                cboArmyLevel.Items.Add(i.ToString());
            }
            displayArmy(army);
        }

        private void frmArmy_Load(object sender, EventArgs e)
        {
            
        }
    
        private void cboArmyID_Validating(object sender, CancelEventArgs e)
        {
            int tempArmyID;
            if (!int.TryParse(cboArmyID.Text, out tempArmyID))
            {
                MessageBox.Show("地塊ID應為整數。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            } else if (!battle.areaList.Any()) {
                MessageBox.Show("請先創造地塊。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            } else if (!battle.areaList.Exists(i => i.id == tempArmyID)){
                MessageBox.Show("該地塊ID並不存在。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else
            {
                if(tempID != -1 && battle.areaList.Find(i => i.id == tempArmyID).armyList.Count < Area.MAX_ARMY) {
                    battle.areaList.Find(i => i.id == tempID).armyList.Remove(army);
                    battle.areaList.Find(i => i.id == tempArmyID).armyList.Add(army);
                }
                else
                {
                    if (tempID != -1)
                    {
                        MessageBox.Show("該地塊已有4個部隊。", "歐三戰役編輯器",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void btnAddArmy_Click(object sender, EventArgs e)
        {
            Area tempArea = battle.areaList.Find(i => i.id == int.Parse(cboArmyID.Text));
            saveArmy();
            if (tempID != -1)
            {
                MessageBox.Show("儲存軍隊成功。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                army = new Army();
                return;
            }
            if (tempArea.armyList.Count < Area.MAX_ARMY) {
                tempArea.armyList.Add(army);
                MessageBox.Show("新增軍隊成功。該地塊現有" + tempArea.armyList.Count +"個部隊。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("該地塊已有4個部隊。不能再新增軍隊！", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            army = new Army();
        }

        private void displayArmy(Army army)
        {
            cboArmyID.Text = tempID.ToString();
            if (army.card.HasFlag(Card.assaultart))
            {
                chkAssault.Checked = true;
            }
            if (army.card.HasFlag(Card.defendart))
            {
                chkDefend.Checked = true;
            }
            if (army.card.HasFlag(Card.carrier))
            {
                chkCarrier.Checked = true;
            }
            if (army.card.HasFlag(Card.commander))
            {
                chkCommander.Checked = true;
            }
            if (army.armyType == ArmyType.infantry)
            {
                rdbInfantary.Checked = true;
            }
            if (army.armyType == ArmyType.cavalry)
            {
                rdbCavalry.Checked = true;
            }
            if (army.armyType == ArmyType.machinegun)
            {
                rdbMachineGun.Checked = true;
            }
            if (army.armyType == ArmyType.artillery)
            {
                rdbArtillery.Checked = true;
            }
            
            if (army.armyType == ArmyType.tank)
            {
                rdbTank.Checked = true;
            }
            if (army.armyType == ArmyType.panzer)
            {
                rdbPanzer.Checked = true;
            }
            if (army.armyType == ArmyType.destroyer)
            {
                rdbDestroyer.Checked = true;
            }
            if (army.armyType == ArmyType.cruiser)
            {
                rdbCruiser.Checked = true;
            }
            if (army.armyType == ArmyType.battleship)
            {
                rdbBattleship.Checked = true;
            }

            cboArmyLevel.SelectedItem = army.level.ToString();
        }

        private void saveArmy()
        {
            army.level = cboArmyLevel.SelectedIndex;
            if (rdbInfantary.Checked)
            {
                army.armyType = ArmyType.infantry;
            }
            else if (rdbCavalry.Checked)
            {
                army.armyType = ArmyType.cavalry;
            }
            else if (rdbMachineGun.Checked)
            {
                army.armyType = ArmyType.machinegun;
            }
            else if (rdbArtillery.Checked)
            {
                army.armyType = ArmyType.artillery;
            }
            else if (rdbPanzer.Checked)
            {
                army.armyType = ArmyType.panzer;
            }
            else if (rdbTank.Checked)
            {
                army.armyType = ArmyType.tank;
            }
            else if (rdbDestroyer.Checked)
            {
                army.armyType = ArmyType.destroyer;
            }
            else if (rdbCruiser.Checked)
            {
                army.armyType = ArmyType.cruiser;
            }
            else if (rdbBattleship.Checked)
            {
                army.armyType = ArmyType.battleship;
            }

            army.card = Card.none;
            if (chkAssault.Checked)
            {
                army.card |= Card.assaultart;
            }
            if (chkDefend.Checked)
            {
                army.card |= Card.defendart;
            }
            if (chkCarrier.Checked)
            {
                army.card |= Card.carrier;
            }
            if (chkCommander.Checked)
            {
                army.card |= Card.commander;
            }
        }
    }
}
