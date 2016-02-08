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
    public partial class frmArea : Form
    {
        private Battle battle;
        private Area area;

        public frmArea(Battle battle)
        {
            InitializeComponent();
            this.battle = battle;
            area = new Area();
            cboAreaID.Text = "1";
            cboAreaCountry.Text = "de";
            rdbNoConstruction.Checked = true;
            rdbNoInstallation.Checked = true;
        }

        public frmArea(Battle battle, Area area)
        {
            InitializeComponent();
            this.battle = battle;
            this.area = area;
            displayArea(area);
        }

        private void frmArea_Load(object sender, EventArgs e)
        {
            foreach (Country country in battle.countryList)
            {
                cboAreaCountry.Items.Add(country.name);
            }

            foreach (Area area in battle.areaList)
            {
                cboAreaID.Items.Add(area.id);
            }
        }

        private void cboAreaID_Validating(object sender, CancelEventArgs e)
        {
            int tempAreaID;
            if (!int.TryParse(cboAreaID.Text, out tempAreaID))
            {
                MessageBox.Show("地塊ID不能為空。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (battle.areaList.Exists(i => i.id.Equals(tempAreaID)))
            {
                area = battle.areaList.Find(i => i.id.Equals(tempAreaID));
                displayArea(area);
            }
        }

        private void cboAreaCountry_Validating(object sender, CancelEventArgs e)
        {
            if (cboAreaCountry.Text.Equals(""))
            {
                MessageBox.Show("國家名稱不能為空。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void rdbNoConstruction_CheckedChanged(object sender, EventArgs e)
        {
            pnlConstructionLevel.Visible = false;
        }

        private void rdbCity_CheckedChanged(object sender, EventArgs e)
        {
            pnlConstructionLevel.Visible = true;

            cboAreaLevel.Items.Clear();
            for (int i = 1; i <= (int)Construction.city; i++)
            {
                cboAreaLevel.Items.Add(i.ToString());
            }
            cboAreaLevel.SelectedItem = "1";
        }

        private void rdbIndustry_CheckedChanged(object sender, EventArgs e)
        {
            pnlConstructionLevel.Visible = true;
            cboAreaLevel.Items.Clear();
            for (int i = 1; i <= (int)Construction.industry; i++)
            {
                cboAreaLevel.Items.Add(i.ToString());
            }
            cboAreaLevel.SelectedItem = "1";
        }

        private void rdbAirport_CheckedChanged(object sender, EventArgs e)
        {
            pnlConstructionLevel.Visible = false;
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            saveArea();
            if (!battle.areaList.Exists(i => i.id == area.id))
            {
                battle.areaList.Add(area);
            }   
            battle.areaList = battle.areaList.OrderBy(x => x.id).ToList();
            area = new Area();
            MessageBox.Show("儲存地塊成功。", "歐三戰役編輯器",
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void displayArea(Area area)
        {
            cboAreaID.Text = area.id.ToString();
            cboAreaCountry.Text = area.country;
            if (area.construction == Construction.none)
            {
                rdbNoConstruction.Checked = true;
                pnlConstructionLevel.Visible = false;
            }
            if (area.construction == Construction.city)
            {
                rdbCity.Checked = true;
                pnlConstructionLevel.Visible = true;
                cboAreaLevel.Items.Clear();
                for (int i = 1; i <= (int)Construction.city; i++)
                {
                    cboAreaLevel.Items.Add(i.ToString());
                }
                cboAreaLevel.SelectedItem = area.level.ToString();

            }
            if (area.construction == Construction.industry)
            {
                rdbIndustry.Checked = true;
                pnlConstructionLevel.Visible = true;
                cboAreaLevel.Items.Clear();
                for (int i = 1; i <= (int)Construction.industry; i++)
                {
                    cboAreaLevel.Items.Add(i.ToString());
                }
                cboAreaLevel.SelectedItem = area.level.ToString();
            }
            if (area.construction == Construction.airport)
            {
                rdbAirport.Checked = true;
                pnlConstructionLevel.Visible = false;
            }
            if (area.installation == Installation.none)
            {
                rdbNoInstallation.Checked = true;
            }

            if (area.installation == Installation.entrenchment)
            {
                rdbEntrenchment.Checked = true;
            }
            if (area.installation == Installation.fort)
            {
                rdbFort.Checked = true;
            }
            if (area.installation == Installation.antiaircraft)
            {
                rdbAntiaircraft.Checked = true;
            }
        }

        private void saveArea()
        {
            area.id = int.Parse(cboAreaID.Text);
            area.country = cboAreaCountry.Text;

            if (rdbNoConstruction.Checked)
            {
                area.construction = Construction.none;
                area.level = (int)Construction.none;
            }
            else if (rdbCity.Checked)
            {
                area.construction = Construction.city;
                area.level = cboAreaLevel.SelectedIndex + 1;
            }
            else if (rdbIndustry.Checked)
            {
                area.construction = Construction.industry;
                area.level = cboAreaLevel.SelectedIndex + 1;
            }
            else if (rdbAirport.Checked)
            {
                area.construction = Construction.airport;
                area.level = (int)Construction.airport;
            }

            if (rdbNoInstallation.Checked)
            {
                area.installation = Installation.none;
            }
            else if (rdbEntrenchment.Checked)
            {
                area.installation = Installation.entrenchment;
            }
            else if (rdbFort.Checked)
            {
                area.installation = Installation.fort;
            }
            else if (rdbAntiaircraft.Checked)
            {
                area.installation = Installation.antiaircraft;
            }
        }
    }
}
