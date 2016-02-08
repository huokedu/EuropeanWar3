namespace EuropeanWar3
{
    partial class frmArmy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArmy));
            this.lblArmyID = new System.Windows.Forms.Label();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.rdbCavalry = new System.Windows.Forms.RadioButton();
            this.rdbBattleship = new System.Windows.Forms.RadioButton();
            this.rdbCruiser = new System.Windows.Forms.RadioButton();
            this.rdbDestroyer = new System.Windows.Forms.RadioButton();
            this.rdbArtillery = new System.Windows.Forms.RadioButton();
            this.rdbPanzer = new System.Windows.Forms.RadioButton();
            this.rdbMachineGun = new System.Windows.Forms.RadioButton();
            this.rdbTank = new System.Windows.Forms.RadioButton();
            this.rdbInfantary = new System.Windows.Forms.RadioButton();
            this.lblArmyLevel = new System.Windows.Forms.Label();
            this.cboArmyLevel = new System.Windows.Forms.ComboBox();
            this.grbUnit1Card = new System.Windows.Forms.GroupBox();
            this.chkCommander = new System.Windows.Forms.CheckBox();
            this.chkCarrier = new System.Windows.Forms.CheckBox();
            this.chkDefend = new System.Windows.Forms.CheckBox();
            this.chkAssault = new System.Windows.Forms.CheckBox();
            this.btnAddArmy = new System.Windows.Forms.Button();
            this.cboArmyID = new System.Windows.Forms.ComboBox();
            this.grbType.SuspendLayout();
            this.grbUnit1Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArmyID
            // 
            this.lblArmyID.AutoSize = true;
            this.lblArmyID.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblArmyID.Location = new System.Drawing.Point(126, 39);
            this.lblArmyID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArmyID.Name = "lblArmyID";
            this.lblArmyID.Size = new System.Drawing.Size(104, 16);
            this.lblArmyID.TabIndex = 0;
            this.lblArmyID.Text = "所在地塊ID：";
            // 
            // grbType
            // 
            this.grbType.AutoSize = true;
            this.grbType.Controls.Add(this.rdbCavalry);
            this.grbType.Controls.Add(this.rdbBattleship);
            this.grbType.Controls.Add(this.rdbCruiser);
            this.grbType.Controls.Add(this.rdbDestroyer);
            this.grbType.Controls.Add(this.rdbArtillery);
            this.grbType.Controls.Add(this.rdbPanzer);
            this.grbType.Controls.Add(this.rdbMachineGun);
            this.grbType.Controls.Add(this.rdbTank);
            this.grbType.Controls.Add(this.rdbInfantary);
            this.grbType.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbType.Location = new System.Drawing.Point(129, 163);
            this.grbType.Margin = new System.Windows.Forms.Padding(4);
            this.grbType.Name = "grbType";
            this.grbType.Padding = new System.Windows.Forms.Padding(4);
            this.grbType.Size = new System.Drawing.Size(583, 144);
            this.grbType.TabIndex = 4;
            this.grbType.TabStop = false;
            this.grbType.Text = "軍隊種類";
            // 
            // rdbCavalry
            // 
            this.rdbCavalry.AutoSize = true;
            this.rdbCavalry.Location = new System.Drawing.Point(164, 24);
            this.rdbCavalry.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCavalry.Name = "rdbCavalry";
            this.rdbCavalry.Size = new System.Drawing.Size(58, 20);
            this.rdbCavalry.TabIndex = 1;
            this.rdbCavalry.Text = "騎兵";
            this.rdbCavalry.UseVisualStyleBackColor = true;
            // 
            // rdbBattleship
            // 
            this.rdbBattleship.AutoSize = true;
            this.rdbBattleship.Location = new System.Drawing.Point(320, 83);
            this.rdbBattleship.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBattleship.Name = "rdbBattleship";
            this.rdbBattleship.Size = new System.Drawing.Size(58, 20);
            this.rdbBattleship.TabIndex = 8;
            this.rdbBattleship.Text = "戰列";
            this.rdbBattleship.UseVisualStyleBackColor = true;
            // 
            // rdbCruiser
            // 
            this.rdbCruiser.AutoSize = true;
            this.rdbCruiser.Location = new System.Drawing.Point(164, 83);
            this.rdbCruiser.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCruiser.Name = "rdbCruiser";
            this.rdbCruiser.Size = new System.Drawing.Size(58, 20);
            this.rdbCruiser.TabIndex = 7;
            this.rdbCruiser.Text = "巡洋";
            this.rdbCruiser.UseVisualStyleBackColor = true;
            // 
            // rdbDestroyer
            // 
            this.rdbDestroyer.AutoSize = true;
            this.rdbDestroyer.Location = new System.Drawing.Point(4, 83);
            this.rdbDestroyer.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDestroyer.Name = "rdbDestroyer";
            this.rdbDestroyer.Size = new System.Drawing.Size(58, 20);
            this.rdbDestroyer.TabIndex = 6;
            this.rdbDestroyer.Text = "驅逐";
            this.rdbDestroyer.UseVisualStyleBackColor = true;
            // 
            // rdbArtillery
            // 
            this.rdbArtillery.AutoSize = true;
            this.rdbArtillery.Location = new System.Drawing.Point(4, 55);
            this.rdbArtillery.Margin = new System.Windows.Forms.Padding(4);
            this.rdbArtillery.Name = "rdbArtillery";
            this.rdbArtillery.Size = new System.Drawing.Size(58, 20);
            this.rdbArtillery.TabIndex = 3;
            this.rdbArtillery.Text = "大砲";
            this.rdbArtillery.UseVisualStyleBackColor = true;
            // 
            // rdbPanzer
            // 
            this.rdbPanzer.AutoSize = true;
            this.rdbPanzer.Location = new System.Drawing.Point(164, 55);
            this.rdbPanzer.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPanzer.Name = "rdbPanzer";
            this.rdbPanzer.Size = new System.Drawing.Size(58, 20);
            this.rdbPanzer.TabIndex = 4;
            this.rdbPanzer.Text = "裝甲";
            this.rdbPanzer.UseVisualStyleBackColor = true;
            // 
            // rdbMachineGun
            // 
            this.rdbMachineGun.AutoSize = true;
            this.rdbMachineGun.Location = new System.Drawing.Point(320, 24);
            this.rdbMachineGun.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMachineGun.Name = "rdbMachineGun";
            this.rdbMachineGun.Size = new System.Drawing.Size(58, 20);
            this.rdbMachineGun.TabIndex = 2;
            this.rdbMachineGun.Text = "機槍";
            this.rdbMachineGun.UseVisualStyleBackColor = true;
            // 
            // rdbTank
            // 
            this.rdbTank.AutoSize = true;
            this.rdbTank.Location = new System.Drawing.Point(320, 55);
            this.rdbTank.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTank.Name = "rdbTank";
            this.rdbTank.Size = new System.Drawing.Size(58, 20);
            this.rdbTank.TabIndex = 5;
            this.rdbTank.Text = "坦克";
            this.rdbTank.UseVisualStyleBackColor = true;
            // 
            // rdbInfantary
            // 
            this.rdbInfantary.AutoSize = true;
            this.rdbInfantary.Checked = true;
            this.rdbInfantary.Location = new System.Drawing.Point(4, 24);
            this.rdbInfantary.Margin = new System.Windows.Forms.Padding(4);
            this.rdbInfantary.Name = "rdbInfantary";
            this.rdbInfantary.Size = new System.Drawing.Size(58, 20);
            this.rdbInfantary.TabIndex = 0;
            this.rdbInfantary.TabStop = true;
            this.rdbInfantary.Text = "步兵";
            this.rdbInfantary.UseVisualStyleBackColor = true;
            // 
            // lblArmyLevel
            // 
            this.lblArmyLevel.AutoSize = true;
            this.lblArmyLevel.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblArmyLevel.Location = new System.Drawing.Point(126, 99);
            this.lblArmyLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArmyLevel.Name = "lblArmyLevel";
            this.lblArmyLevel.Size = new System.Drawing.Size(88, 16);
            this.lblArmyLevel.TabIndex = 2;
            this.lblArmyLevel.Text = "軍隊等級：";
            // 
            // cboArmyLevel
            // 
            this.cboArmyLevel.AllowDrop = true;
            this.cboArmyLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArmyLevel.Font = new System.Drawing.Font("新細明體", 12F);
            this.cboArmyLevel.FormattingEnabled = true;
            this.cboArmyLevel.Location = new System.Drawing.Point(387, 99);
            this.cboArmyLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cboArmyLevel.Name = "cboArmyLevel";
            this.cboArmyLevel.Size = new System.Drawing.Size(180, 24);
            this.cboArmyLevel.TabIndex = 3;
            // 
            // grbUnit1Card
            // 
            this.grbUnit1Card.Controls.Add(this.chkCommander);
            this.grbUnit1Card.Controls.Add(this.chkCarrier);
            this.grbUnit1Card.Controls.Add(this.chkDefend);
            this.grbUnit1Card.Controls.Add(this.chkAssault);
            this.grbUnit1Card.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbUnit1Card.Location = new System.Drawing.Point(129, 331);
            this.grbUnit1Card.Margin = new System.Windows.Forms.Padding(4);
            this.grbUnit1Card.Name = "grbUnit1Card";
            this.grbUnit1Card.Padding = new System.Windows.Forms.Padding(4);
            this.grbUnit1Card.Size = new System.Drawing.Size(583, 75);
            this.grbUnit1Card.TabIndex = 5;
            this.grbUnit1Card.TabStop = false;
            this.grbUnit1Card.Text = "特殊卡牌";
            // 
            // chkCommander
            // 
            this.chkCommander.AutoSize = true;
            this.chkCommander.Location = new System.Drawing.Point(453, 28);
            this.chkCommander.Margin = new System.Windows.Forms.Padding(4);
            this.chkCommander.Name = "chkCommander";
            this.chkCommander.Size = new System.Drawing.Size(75, 20);
            this.chkCommander.TabIndex = 3;
            this.chkCommander.Text = "指揮官";
            this.chkCommander.UseVisualStyleBackColor = true;
            // 
            // chkCarrier
            // 
            this.chkCarrier.AutoSize = true;
            this.chkCarrier.Location = new System.Drawing.Point(320, 28);
            this.chkCarrier.Margin = new System.Windows.Forms.Padding(4);
            this.chkCarrier.Name = "chkCarrier";
            this.chkCarrier.Size = new System.Drawing.Size(75, 20);
            this.chkCarrier.TabIndex = 2;
            this.chkCarrier.Text = "運輸船";
            this.chkCarrier.UseVisualStyleBackColor = true;
            // 
            // chkDefend
            // 
            this.chkDefend.AutoSize = true;
            this.chkDefend.Location = new System.Drawing.Point(164, 28);
            this.chkDefend.Margin = new System.Windows.Forms.Padding(4);
            this.chkDefend.Name = "chkDefend";
            this.chkDefend.Size = new System.Drawing.Size(91, 20);
            this.chkDefend.TabIndex = 1;
            this.chkDefend.Text = "防禦戰術";
            this.chkDefend.UseVisualStyleBackColor = true;
            // 
            // chkAssault
            // 
            this.chkAssault.AutoSize = true;
            this.chkAssault.Location = new System.Drawing.Point(9, 28);
            this.chkAssault.Margin = new System.Windows.Forms.Padding(4);
            this.chkAssault.Name = "chkAssault";
            this.chkAssault.Size = new System.Drawing.Size(91, 20);
            this.chkAssault.TabIndex = 0;
            this.chkAssault.Text = "突擊戰術";
            this.chkAssault.UseVisualStyleBackColor = true;
            // 
            // btnAddArmy
            // 
            this.btnAddArmy.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAddArmy.Location = new System.Drawing.Point(626, 457);
            this.btnAddArmy.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddArmy.Name = "btnAddArmy";
            this.btnAddArmy.Size = new System.Drawing.Size(112, 31);
            this.btnAddArmy.TabIndex = 6;
            this.btnAddArmy.Text = "儲存軍隊";
            this.btnAddArmy.UseVisualStyleBackColor = true;
            this.btnAddArmy.Click += new System.EventHandler(this.btnAddArmy_Click);
            // 
            // cboArmyID
            // 
            this.cboArmyID.Font = new System.Drawing.Font("新細明體", 12F);
            this.cboArmyID.FormattingEnabled = true;
            this.cboArmyID.Location = new System.Drawing.Point(387, 35);
            this.cboArmyID.Margin = new System.Windows.Forms.Padding(4);
            this.cboArmyID.Name = "cboArmyID";
            this.cboArmyID.Size = new System.Drawing.Size(180, 24);
            this.cboArmyID.TabIndex = 1;
            this.cboArmyID.Validating += new System.ComponentModel.CancelEventHandler(this.cboArmyID_Validating);
            // 
            // frmArmy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cboArmyID);
            this.Controls.Add(this.btnAddArmy);
            this.Controls.Add(this.grbUnit1Card);
            this.Controls.Add(this.lblArmyLevel);
            this.Controls.Add(this.cboArmyLevel);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.lblArmyID);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArmy";
            this.Text = "軍隊設定";
            this.Load += new System.EventHandler(this.frmArmy_Load);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbUnit1Card.ResumeLayout(false);
            this.grbUnit1Card.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArmyID;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.RadioButton rdbBattleship;
        private System.Windows.Forms.RadioButton rdbCruiser;
        private System.Windows.Forms.RadioButton rdbDestroyer;
        private System.Windows.Forms.RadioButton rdbArtillery;
        private System.Windows.Forms.RadioButton rdbPanzer;
        private System.Windows.Forms.RadioButton rdbMachineGun;
        private System.Windows.Forms.RadioButton rdbTank;
        private System.Windows.Forms.RadioButton rdbInfantary;
        private System.Windows.Forms.Label lblArmyLevel;
        private System.Windows.Forms.ComboBox cboArmyLevel;
        private System.Windows.Forms.GroupBox grbUnit1Card;
        private System.Windows.Forms.CheckBox chkCommander;
        private System.Windows.Forms.CheckBox chkCarrier;
        private System.Windows.Forms.CheckBox chkDefend;
        private System.Windows.Forms.CheckBox chkAssault;
        private System.Windows.Forms.Button btnAddArmy;
        private System.Windows.Forms.ComboBox cboArmyID;
        private System.Windows.Forms.RadioButton rdbCavalry;
    }
}