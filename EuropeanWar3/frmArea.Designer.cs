namespace EuropeanWar3
{
    partial class frmArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArea));
            this.lblAreaID = new System.Windows.Forms.Label();
            this.lblAreaCountry = new System.Windows.Forms.Label();
            this.cboAreaCountry = new System.Windows.Forms.ComboBox();
            this.grbConstruction = new System.Windows.Forms.GroupBox();
            this.pnlConstructionLevel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblConstructionLevel = new System.Windows.Forms.Label();
            this.cboAreaLevel = new System.Windows.Forms.ComboBox();
            this.rdbNoConstruction = new System.Windows.Forms.RadioButton();
            this.rdbAirport = new System.Windows.Forms.RadioButton();
            this.rdbIndustry = new System.Windows.Forms.RadioButton();
            this.rdbCity = new System.Windows.Forms.RadioButton();
            this.grbInstallation = new System.Windows.Forms.GroupBox();
            this.rdbNoInstallation = new System.Windows.Forms.RadioButton();
            this.rdbAntiaircraft = new System.Windows.Forms.RadioButton();
            this.rdbFort = new System.Windows.Forms.RadioButton();
            this.rdbEntrenchment = new System.Windows.Forms.RadioButton();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.cboAreaID = new System.Windows.Forms.ComboBox();
            this.grbConstruction.SuspendLayout();
            this.pnlConstructionLevel.SuspendLayout();
            this.grbInstallation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAreaID
            // 
            this.lblAreaID.AutoSize = true;
            this.lblAreaID.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAreaID.Location = new System.Drawing.Point(100, 50);
            this.lblAreaID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaID.Name = "lblAreaID";
            this.lblAreaID.Size = new System.Drawing.Size(60, 16);
            this.lblAreaID.TabIndex = 0;
            this.lblAreaID.Text = "地塊ID:";
            // 
            // lblAreaCountry
            // 
            this.lblAreaCountry.AutoSize = true;
            this.lblAreaCountry.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblAreaCountry.Location = new System.Drawing.Point(100, 110);
            this.lblAreaCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAreaCountry.Name = "lblAreaCountry";
            this.lblAreaCountry.Size = new System.Drawing.Size(76, 16);
            this.lblAreaCountry.TabIndex = 2;
            this.lblAreaCountry.Text = "國家名稱:";
            // 
            // cboAreaCountry
            // 
            this.cboAreaCountry.AllowDrop = true;
            this.cboAreaCountry.Font = new System.Drawing.Font("新細明體", 12F);
            this.cboAreaCountry.FormattingEnabled = true;
            this.cboAreaCountry.Location = new System.Drawing.Point(300, 107);
            this.cboAreaCountry.Margin = new System.Windows.Forms.Padding(4);
            this.cboAreaCountry.Name = "cboAreaCountry";
            this.cboAreaCountry.Size = new System.Drawing.Size(180, 24);
            this.cboAreaCountry.TabIndex = 3;
            this.cboAreaCountry.Validating += new System.ComponentModel.CancelEventHandler(this.cboAreaCountry_Validating);
            // 
            // grbConstruction
            // 
            this.grbConstruction.Controls.Add(this.pnlConstructionLevel);
            this.grbConstruction.Controls.Add(this.rdbNoConstruction);
            this.grbConstruction.Controls.Add(this.rdbAirport);
            this.grbConstruction.Controls.Add(this.rdbIndustry);
            this.grbConstruction.Controls.Add(this.rdbCity);
            this.grbConstruction.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbConstruction.Location = new System.Drawing.Point(100, 150);
            this.grbConstruction.Margin = new System.Windows.Forms.Padding(4);
            this.grbConstruction.Name = "grbConstruction";
            this.grbConstruction.Padding = new System.Windows.Forms.Padding(4);
            this.grbConstruction.Size = new System.Drawing.Size(630, 120);
            this.grbConstruction.TabIndex = 4;
            this.grbConstruction.TabStop = false;
            this.grbConstruction.Text = "基礎建設";
            // 
            // pnlConstructionLevel
            // 
            this.pnlConstructionLevel.Controls.Add(this.lblConstructionLevel);
            this.pnlConstructionLevel.Controls.Add(this.cboAreaLevel);
            this.pnlConstructionLevel.Location = new System.Drawing.Point(370, 50);
            this.pnlConstructionLevel.Margin = new System.Windows.Forms.Padding(4);
            this.pnlConstructionLevel.Name = "pnlConstructionLevel";
            this.pnlConstructionLevel.Size = new System.Drawing.Size(243, 43);
            this.pnlConstructionLevel.TabIndex = 0;
            this.pnlConstructionLevel.Visible = false;
            // 
            // lblConstructionLevel
            // 
            this.lblConstructionLevel.AutoSize = true;
            this.lblConstructionLevel.Location = new System.Drawing.Point(4, 0);
            this.lblConstructionLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConstructionLevel.Name = "lblConstructionLevel";
            this.lblConstructionLevel.Size = new System.Drawing.Size(56, 16);
            this.lblConstructionLevel.TabIndex = 1;
            this.lblConstructionLevel.Text = "等級：";
            // 
            // cboAreaLevel
            // 
            this.cboAreaLevel.AllowDrop = true;
            this.cboAreaLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.cboAreaLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAreaLevel.FormattingEnabled = true;
            this.cboAreaLevel.Location = new System.Drawing.Point(68, 4);
            this.cboAreaLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cboAreaLevel.Name = "cboAreaLevel";
            this.cboAreaLevel.Size = new System.Drawing.Size(162, 24);
            this.cboAreaLevel.TabIndex = 0;
            // 
            // rdbNoConstruction
            // 
            this.rdbNoConstruction.AutoSize = true;
            this.rdbNoConstruction.Font = new System.Drawing.Font("新細明體", 12F);
            this.rdbNoConstruction.Location = new System.Drawing.Point(10, 60);
            this.rdbNoConstruction.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNoConstruction.Name = "rdbNoConstruction";
            this.rdbNoConstruction.Size = new System.Drawing.Size(58, 20);
            this.rdbNoConstruction.TabIndex = 0;
            this.rdbNoConstruction.Text = "沒有";
            this.rdbNoConstruction.UseVisualStyleBackColor = true;
            this.rdbNoConstruction.CheckedChanged += new System.EventHandler(this.rdbNoConstruction_CheckedChanged);
            // 
            // rdbAirport
            // 
            this.rdbAirport.AutoSize = true;
            this.rdbAirport.Location = new System.Drawing.Point(310, 60);
            this.rdbAirport.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAirport.Name = "rdbAirport";
            this.rdbAirport.Size = new System.Drawing.Size(58, 20);
            this.rdbAirport.TabIndex = 3;
            this.rdbAirport.Text = "機場";
            this.rdbAirport.UseVisualStyleBackColor = true;
            this.rdbAirport.CheckedChanged += new System.EventHandler(this.rdbAirport_CheckedChanged);
            // 
            // rdbIndustry
            // 
            this.rdbIndustry.AutoSize = true;
            this.rdbIndustry.Location = new System.Drawing.Point(200, 60);
            this.rdbIndustry.Margin = new System.Windows.Forms.Padding(4);
            this.rdbIndustry.Name = "rdbIndustry";
            this.rdbIndustry.Size = new System.Drawing.Size(58, 20);
            this.rdbIndustry.TabIndex = 2;
            this.rdbIndustry.Text = "工業";
            this.rdbIndustry.UseVisualStyleBackColor = true;
            this.rdbIndustry.CheckedChanged += new System.EventHandler(this.rdbIndustry_CheckedChanged);
            // 
            // rdbCity
            // 
            this.rdbCity.AutoSize = true;
            this.rdbCity.Location = new System.Drawing.Point(110, 60);
            this.rdbCity.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCity.Name = "rdbCity";
            this.rdbCity.Size = new System.Drawing.Size(58, 20);
            this.rdbCity.TabIndex = 1;
            this.rdbCity.Text = "城市";
            this.rdbCity.UseVisualStyleBackColor = true;
            this.rdbCity.CheckedChanged += new System.EventHandler(this.rdbCity_CheckedChanged);
            // 
            // grbInstallation
            // 
            this.grbInstallation.Controls.Add(this.rdbNoInstallation);
            this.grbInstallation.Controls.Add(this.rdbAntiaircraft);
            this.grbInstallation.Controls.Add(this.rdbFort);
            this.grbInstallation.Controls.Add(this.rdbEntrenchment);
            this.grbInstallation.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbInstallation.Location = new System.Drawing.Point(100, 287);
            this.grbInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.grbInstallation.Name = "grbInstallation";
            this.grbInstallation.Padding = new System.Windows.Forms.Padding(4);
            this.grbInstallation.Size = new System.Drawing.Size(630, 120);
            this.grbInstallation.TabIndex = 5;
            this.grbInstallation.TabStop = false;
            this.grbInstallation.Text = "防禦工事";
            // 
            // rdbNoInstallation
            // 
            this.rdbNoInstallation.AutoSize = true;
            this.rdbNoInstallation.Location = new System.Drawing.Point(10, 60);
            this.rdbNoInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNoInstallation.Name = "rdbNoInstallation";
            this.rdbNoInstallation.Size = new System.Drawing.Size(58, 20);
            this.rdbNoInstallation.TabIndex = 0;
            this.rdbNoInstallation.TabStop = true;
            this.rdbNoInstallation.Text = "沒有";
            this.rdbNoInstallation.UseVisualStyleBackColor = true;
            // 
            // rdbAntiaircraft
            // 
            this.rdbAntiaircraft.AutoSize = true;
            this.rdbAntiaircraft.Location = new System.Drawing.Point(310, 60);
            this.rdbAntiaircraft.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAntiaircraft.Name = "rdbAntiaircraft";
            this.rdbAntiaircraft.Size = new System.Drawing.Size(58, 20);
            this.rdbAntiaircraft.TabIndex = 3;
            this.rdbAntiaircraft.Text = "防空";
            this.rdbAntiaircraft.UseVisualStyleBackColor = true;
            // 
            // rdbFort
            // 
            this.rdbFort.AutoSize = true;
            this.rdbFort.Location = new System.Drawing.Point(210, 60);
            this.rdbFort.Margin = new System.Windows.Forms.Padding(4);
            this.rdbFort.Name = "rdbFort";
            this.rdbFort.Size = new System.Drawing.Size(58, 20);
            this.rdbFort.TabIndex = 2;
            this.rdbFort.Text = "要塞";
            this.rdbFort.UseVisualStyleBackColor = true;
            // 
            // rdbEntrenchment
            // 
            this.rdbEntrenchment.AutoSize = true;
            this.rdbEntrenchment.Location = new System.Drawing.Point(110, 60);
            this.rdbEntrenchment.Margin = new System.Windows.Forms.Padding(4);
            this.rdbEntrenchment.Name = "rdbEntrenchment";
            this.rdbEntrenchment.Size = new System.Drawing.Size(58, 20);
            this.rdbEntrenchment.TabIndex = 1;
            this.rdbEntrenchment.Text = "戰壕";
            this.rdbEntrenchment.UseVisualStyleBackColor = true;
            // 
            // btnAddArea
            // 
            this.btnAddArea.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAddArea.Location = new System.Drawing.Point(618, 477);
            this.btnAddArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(112, 31);
            this.btnAddArea.TabIndex = 6;
            this.btnAddArea.Text = "儲存地塊";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // cboAreaID
            // 
            this.cboAreaID.Font = new System.Drawing.Font("新細明體", 12F);
            this.cboAreaID.FormattingEnabled = true;
            this.cboAreaID.Location = new System.Drawing.Point(300, 50);
            this.cboAreaID.Margin = new System.Windows.Forms.Padding(4);
            this.cboAreaID.Name = "cboAreaID";
            this.cboAreaID.Size = new System.Drawing.Size(180, 24);
            this.cboAreaID.TabIndex = 1;
            this.cboAreaID.Validating += new System.ComponentModel.CancelEventHandler(this.cboAreaID_Validating);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cboAreaID);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.grbInstallation);
            this.Controls.Add(this.grbConstruction);
            this.Controls.Add(this.lblAreaID);
            this.Controls.Add(this.lblAreaCountry);
            this.Controls.Add(this.cboAreaCountry);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmArea";
            this.Text = "地塊設定";
            this.Load += new System.EventHandler(this.frmArea_Load);
            this.grbConstruction.ResumeLayout(false);
            this.grbConstruction.PerformLayout();
            this.pnlConstructionLevel.ResumeLayout(false);
            this.pnlConstructionLevel.PerformLayout();
            this.grbInstallation.ResumeLayout(false);
            this.grbInstallation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAreaID;
        private System.Windows.Forms.Label lblAreaCountry;
        private System.Windows.Forms.ComboBox cboAreaCountry;
        private System.Windows.Forms.GroupBox grbConstruction;
        private System.Windows.Forms.GroupBox grbInstallation;
        private System.Windows.Forms.RadioButton rdbAntiaircraft;
        private System.Windows.Forms.RadioButton rdbFort;
        private System.Windows.Forms.RadioButton rdbEntrenchment;
        private System.Windows.Forms.RadioButton rdbNoInstallation;
        private System.Windows.Forms.RadioButton rdbNoConstruction;
        private System.Windows.Forms.RadioButton rdbAirport;
        private System.Windows.Forms.RadioButton rdbIndustry;
        private System.Windows.Forms.RadioButton rdbCity;
        private System.Windows.Forms.FlowLayoutPanel pnlConstructionLevel;
        private System.Windows.Forms.Label lblConstructionLevel;
        private System.Windows.Forms.ComboBox cboAreaLevel;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.ComboBox cboAreaID;
    }
}