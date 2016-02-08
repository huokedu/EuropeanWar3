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
    public partial class frmCountry : Form
    {
        private Battle battle;
        private Country country;

        public frmCountry(Battle battle)
        {
            InitializeComponent();
            this.battle = battle;
            country = new Country();
            if (battle.countryList != null)
            {
                foreach (Country tempcountry in battle.countryList)
                {
                    cboCountryName.Items.Add(tempcountry.name);
                }
            }
            cboCountryName.Text = "de";
            rdbAiYes.Checked = true;
            txtMoney.Text = "100";
            txtIndustry.Text = "100";
            txtTechLevel.Text = "3";
            rdbAllianceA.Checked = true;
            txtColorR.Text = "0";
            txtColorG.Text = "0";
            txtColorB.Text = "0";
            txtColorA.Text = "0";
        }

        public frmCountry(Battle battle, Country country)
        {
            InitializeComponent();
            this.battle = battle;
            this.country = country;
            if (battle.countryList != null)
            {
                foreach (Country tempcountry in battle.countryList)
                {
                    cboCountryName.Items.Add(tempcountry.name);
                }
            }
            displayCountry(country);
        }

        private void cboCountryName_Validating(object sender, CancelEventArgs e)
        {
            if (cboCountryName.Text.Equals(""))
            {
                MessageBox.Show("請設定國家ID。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (battle.countryList.Exists(i => i.name.Equals(cboCountryName.Text)))
            {
                country = battle.countryList.Find(i => i.name.Equals(cboCountryName.Text));
                displayCountry(country);
            }
        }

        private void btnSaveCountry_Click(object sender, EventArgs e)
        {
            setCountry();
            if (!battle.countryList.Exists(i => i.name.Equals(country.name)))
            {
                battle.countryList.Add(country);
            }  
            country = new Country();
            MessageBox.Show("儲存國家成功。", "歐三戰役編輯器",
            MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        private void txtMoney_Validating(object sender, CancelEventArgs e)
        {
            int tempMoney;
            if (!int.TryParse(txtMoney.Text, out tempMoney))
            {
                MessageBox.Show("金錢必須為數字。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void txtIndustry_Validating(object sender, CancelEventArgs e)
        {
            int tempIndustry;
            if (!int.TryParse(txtIndustry.Text, out tempIndustry))
            {
                MessageBox.Show("工業必須為數字。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void txtTechLevel_Validating(object sender, CancelEventArgs e)
        {
            int tempTechLevel;
            if (!int.TryParse(txtTechLevel.Text, out tempTechLevel))
            {
                MessageBox.Show("科技必須為數字。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (!((tempTechLevel >= Country.MIN_TECH) && (tempTechLevel <= Country.MAX_TECH)))
            {
                MessageBox.Show("科技必須在0至5之間。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void cboCommander_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtColorR_Validating(object sender, CancelEventArgs e)
        {
            int tempColorR;
            if (!int.TryParse(txtColorR.Text, out tempColorR))
            {
                MessageBox.Show("色彩值必須為數字。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (!((tempColorR >= 0) && (tempColorR <= 255)))
            {
                MessageBox.Show("色彩值必須在0至255之間。", "歐三戰役編輯器",
              MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void txtColorG_Validating(object sender, CancelEventArgs e)
        {
            int tempColorG;
            if (!int.TryParse(txtColorG.Text, out tempColorG))
            {
                MessageBox.Show("色彩值必須為數字。", "歐三戰役編輯器",
                MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (!((tempColorG >= 0) && (tempColorG <= 255)))
            {
                MessageBox.Show("色彩值必須在0至255之間。", "歐三戰役編輯器",
               MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void txtColorB_Validating(object sender, CancelEventArgs e)
        {
            int tempColorB;
            if (!int.TryParse(txtColorB.Text, out tempColorB))
            {
                MessageBox.Show("色彩值必須為數字。", "歐三戰役編輯器",
                 MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (!((tempColorB >= 0) && (tempColorB <= 255)))
            {
                MessageBox.Show("色彩值必須在0至255之間。", "歐三戰役編輯器",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void txtColorA_Validating(object sender, CancelEventArgs e)
        {
            int tempColorA;
            if (!int.TryParse(txtColorA.Text, out tempColorA))
            {
                MessageBox.Show("色彩值必須為數字。", "歐三戰役編輯器",
                  MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
            else if (!((tempColorA >= 0) && (tempColorA <= 255)))
            {
                MessageBox.Show("色彩值必須在0至255之間。", "歐三戰役編輯器",
                        MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                e.Cancel = true;
            }
        }

        private void setCountry()
        {
            country.name = cboCountryName.Text;
            if (rdbAiYes.Checked)
            {
                country.ai = 1;
            }
            else
            {
                country.ai = 0;
            }
            country.money = int.Parse(txtMoney.Text);
            country.industry = int.Parse(txtIndustry.Text);
            country.techlevel = int.Parse(txtTechLevel.Text);

            if (rdbAllianceA.Checked)
            {
                country.alliance = Alliance.a;
            }
            if (rdbAllianceB.Checked)
            {
                country.alliance = Alliance.b;
            }
            if (rdbAllianceC.Checked)
            {
                country.alliance = Alliance.c;
            }
            if (rdbAllianceN.Checked)
            {
                country.alliance = Alliance.n;
            }
            
            country.color = new EuropeanWar3Library.Color
            {
                r = int.Parse(txtColorR.Text),
                g = int.Parse(txtColorB.Text),
                b = int.Parse(txtColorG.Text),
                a = int.Parse(txtColorA.Text)
            };
        }

        private void displayCountry(Country country)
        {
            cboCountryName.Text = country.name;
            if (country.ai == 0)
            {
                rdbAiNo.Checked = true;
            }
            else
            {
                rdbAiYes.Checked = true;
            }
            txtMoney.Text = country.money.ToString();
            txtIndustry.Text = country.industry.ToString();
            txtTechLevel.Text = country.techlevel.ToString();
            if (country.alliance == Alliance.a)
            {
                rdbAllianceA.Checked = true;
            }
            if (country.alliance == Alliance.b)
            {
                rdbAllianceB.Checked = true;
            }
            if (country.alliance == Alliance.c)
            {
                rdbAllianceC.Checked = true;
            }
            if (country.alliance == Alliance.n)
            {
                rdbAllianceN.Checked = true;
            }
            txtColorR.Text = country.color.r.ToString();
            txtColorG.Text = country.color.g.ToString();
            txtColorB.Text = country.color.b.ToString();
            txtColorA.Text = country.color.a.ToString();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {

        }
    }
}
