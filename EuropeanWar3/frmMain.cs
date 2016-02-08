using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using EuropeanWar3Library;

namespace EuropeanWar3
{
    public partial class frmMain : Form
    {
        private Battle battle = new Battle();
        public frmMain()
        {
            InitializeComponent();
            battle = new Battle();
        }

        private void btnAddBattle_Click(object sender, EventArgs e)
        {
            frmBattle f = new frmBattle(battle);
            f.ShowDialog();
        }

        private void btnAddCountry_Click(object sender, EventArgs e)
        {
            frmCountry f;
            f = new frmCountry(battle);
            f.ShowDialog();
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            frmArea f;
            f = new frmArea(battle);
            f.ShowDialog();
        }

        private void btnAddArmy_Click(object sender, EventArgs e)
        {
            frmArmy f;
            if (treBattle.SelectedNode != null && treBattle.SelectedNode.Tag.GetType() == typeof(Area))
            {
                f = new frmArmy(battle, ((Area)treBattle.SelectedNode.Tag).id);
            }
            else
            {
                f = new frmArmy(battle);
            }
            f.ShowDialog();
        }

        private void showTreeView(object sender, EventArgs e)
        {
            treBattle.Nodes.Clear();

            treBattle.Nodes.Add("Battle");
            treBattle.Nodes[0].Tag = battle;

            treBattle.Nodes[0].Nodes.Add("Country");
            treBattle.Nodes[0].Nodes[0].Tag = battle.countryList;
            treBattle.Nodes[0].Nodes.Add("Area");
            treBattle.Nodes[0].Nodes[1].Tag = battle.areaList;

            foreach (Country country in battle.countryList)
            {
                TreeNode countryNode = new TreeNode(country.name);
                countryNode.Name = country.name;
                countryNode.Tag = country;
                treBattle.Nodes[0].Nodes[0].Nodes.Add(countryNode);
            }


            battle.areaList = battle.areaList.OrderBy(x => x.id).ToList();
            foreach (Area area in battle.areaList)
            {
                TreeNode areaNode = new TreeNode(area.id.ToString());
                areaNode.Name = area.id.ToString();
                areaNode.Tag = area;

                treBattle.Nodes[0].Nodes[1].Nodes.Add(areaNode);
                foreach (Army army in area.armyList)
                {
                    TreeNode armyNode = new TreeNode(army.armyType.ToString());
                    armyNode.Tag = army;
                    areaNode.Nodes.Add(armyNode);
                }
            }

            treBattle.ExpandAll();
        }

        private void treBattle_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OpenDialog(e);
        }

        private void OpenDialog(TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag.GetType() == typeof(Area))
            {
                frmArea f = new frmArea(battle, (Area)e.Node.Tag);
                f.ShowDialog();
            }
            if (e.Node.Tag.GetType() == typeof(Army))
            {
                frmArmy f = new frmArmy(battle, (Army)e.Node.Tag, ((Area)e.Node.Parent.Tag).id);
                f.ShowDialog();
            }
            if (e.Node.Tag.GetType() == typeof(Country))
            {
                frmCountry f = new frmCountry(battle, (Country)e.Node.Tag);
                f.ShowDialog();
            }
        }

        private void RemoveNode(object sender, EventArgs e)
        {
            if (treBattle.SelectedNode.Tag.GetType() == typeof(Country))
            {
                battle.countryList.Remove((Country)treBattle.SelectedNode.Tag);
            }
            if (treBattle.SelectedNode.Tag.GetType() == typeof(Area))
            {
                battle.areaList.Remove((Area)treBattle.SelectedNode.Tag);
            }

            if (treBattle.SelectedNode.Tag.GetType() == typeof(Army))
            {
                ((Area)treBattle.SelectedNode.Parent.Tag).armyList.Remove((Army)treBattle.SelectedNode.Tag);
            }

            treBattle.SelectedNode.Remove();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要新增戰役嗎？", "歐三戰役編輯器",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                battle = new Battle();
                treBattle.Nodes.Clear();
                MessageBox.Show("新增戰役成功。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("您確定要讀取戰役嗎？", "歐三戰役編輯器",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                battle = new Battle();
                treBattle.Nodes.Clear();
                openXMLFile.DefaultExt = "xml";
                openXMLFile.Filter = "XML file|*.xml";
                if (openXMLFile.ShowDialog() == DialogResult.OK)
                {
                    string error = battle.ReadFile(openXMLFile.FileName);
                    if (!error.Equals(""))
                    {
                        DialogResult result2 = MessageBox.Show("讀取戰役失敗。是否打開錯誤信息？", "歐三戰役編輯器",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        if (result2 == DialogResult.OK)
                        {
                            MessageBox.Show(error, "歐三戰役編輯器",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("讀取戰役成功。", "歐三戰役編輯器",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                showTreeView(sender, e);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveXMLFile.FileName = battle.battleName;
            saveXMLFile.DefaultExt = "xml";
            saveXMLFile.Filter = "XML file|*.xml";
            if (saveXMLFile.ShowDialog() == DialogResult.OK)
            {
                battle.SaveFile(saveXMLFile.FileName);
            }
            MessageBox.Show("儲存戰役成功。", "歐三戰役編輯器",
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (treBattle.Nodes[0].Nodes[1].Nodes.Count > 0)
            {
                battle.areaList = battle.areaList.OrderBy(x => x.id).ToList();
                treBattle.Nodes[0].Nodes[1].Remove();
                treBattle.Nodes[0].Nodes.Add("Area");
                treBattle.Nodes[0].Nodes[1].Tag = battle.areaList;
                showTreeView(sender, e);
            }
        }
    }
}
