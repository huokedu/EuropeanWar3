namespace EuropeanWar3
{
    partial class frmCountry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountry));
            this.lblCountryName = new System.Windows.Forms.Label();
            this.grbAIControl = new System.Windows.Forms.GroupBox();
            this.rdbAiYes = new System.Windows.Forms.RadioButton();
            this.rdbAiNo = new System.Windows.Forms.RadioButton();
            this.grbColor = new System.Windows.Forms.GroupBox();
            this.lblColorA = new System.Windows.Forms.Label();
            this.lblColorB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblColorR = new System.Windows.Forms.Label();
            this.txtColorA = new System.Windows.Forms.TextBox();
            this.txtColorB = new System.Windows.Forms.TextBox();
            this.txtColorG = new System.Windows.Forms.TextBox();
            this.txtColorR = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblIndustry = new System.Windows.Forms.Label();
            this.txtIndustry = new System.Windows.Forms.TextBox();
            this.lblTechLevel = new System.Windows.Forms.Label();
            this.txtTechLevel = new System.Windows.Forms.TextBox();
            this.grbAlliance = new System.Windows.Forms.GroupBox();
            this.rdbAllianceN = new System.Windows.Forms.RadioButton();
            this.rdbAllianceC = new System.Windows.Forms.RadioButton();
            this.rdbAllianceB = new System.Windows.Forms.RadioButton();
            this.rdbAllianceA = new System.Windows.Forms.RadioButton();
            this.btnSaveCountry = new System.Windows.Forms.Button();
            this.cboCountryName = new System.Windows.Forms.ComboBox();
            this.grbAIControl.SuspendLayout();
            this.grbColor.SuspendLayout();
            this.grbAlliance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCountryName
            // 
            this.lblCountryName.AutoSize = true;
            this.lblCountryName.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblCountryName.Location = new System.Drawing.Point(33, 84);
            this.lblCountryName.Name = "lblCountryName";
            this.lblCountryName.Size = new System.Drawing.Size(88, 16);
            this.lblCountryName.TabIndex = 2;
            this.lblCountryName.Text = "國家名稱：";
            // 
            // grbAIControl
            // 
            this.grbAIControl.Controls.Add(this.rdbAiYes);
            this.grbAIControl.Controls.Add(this.rdbAiNo);
            this.grbAIControl.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbAIControl.Location = new System.Drawing.Point(35, 134);
            this.grbAIControl.Name = "grbAIControl";
            this.grbAIControl.Size = new System.Drawing.Size(221, 76);
            this.grbAIControl.TabIndex = 4;
            this.grbAIControl.TabStop = false;
            this.grbAIControl.Text = "AI控制";
            // 
            // rdbAiYes
            // 
            this.rdbAiYes.AutoSize = true;
            this.rdbAiYes.Location = new System.Drawing.Point(19, 36);
            this.rdbAiYes.Name = "rdbAiYes";
            this.rdbAiYes.Size = new System.Drawing.Size(42, 20);
            this.rdbAiYes.TabIndex = 0;
            this.rdbAiYes.Text = "是";
            this.rdbAiYes.UseVisualStyleBackColor = true;
            // 
            // rdbAiNo
            // 
            this.rdbAiNo.AutoSize = true;
            this.rdbAiNo.Location = new System.Drawing.Point(161, 36);
            this.rdbAiNo.Name = "rdbAiNo";
            this.rdbAiNo.Size = new System.Drawing.Size(42, 20);
            this.rdbAiNo.TabIndex = 1;
            this.rdbAiNo.Text = "否";
            this.rdbAiNo.UseVisualStyleBackColor = true;
            // 
            // grbColor
            // 
            this.grbColor.Controls.Add(this.lblColorA);
            this.grbColor.Controls.Add(this.lblColorB);
            this.grbColor.Controls.Add(this.label1);
            this.grbColor.Controls.Add(this.lblColorR);
            this.grbColor.Controls.Add(this.txtColorA);
            this.grbColor.Controls.Add(this.txtColorB);
            this.grbColor.Controls.Add(this.txtColorG);
            this.grbColor.Controls.Add(this.txtColorR);
            this.grbColor.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbColor.Location = new System.Drawing.Point(35, 335);
            this.grbColor.Name = "grbColor";
            this.grbColor.Size = new System.Drawing.Size(594, 76);
            this.grbColor.TabIndex = 17;
            this.grbColor.TabStop = false;
            this.grbColor.Text = "顏色";
            // 
            // lblColorA
            // 
            this.lblColorA.AutoSize = true;
            this.lblColorA.Location = new System.Drawing.Point(461, 34);
            this.lblColorA.Name = "lblColorA";
            this.lblColorA.Size = new System.Drawing.Size(27, 16);
            this.lblColorA.TabIndex = 6;
            this.lblColorA.Text = "A: ";
            // 
            // lblColorB
            // 
            this.lblColorB.AutoSize = true;
            this.lblColorB.Location = new System.Drawing.Point(299, 34);
            this.lblColorB.Name = "lblColorB";
            this.lblColorB.Size = new System.Drawing.Size(26, 16);
            this.lblColorB.TabIndex = 4;
            this.lblColorB.Text = "B: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "G: ";
            // 
            // lblColorR
            // 
            this.lblColorR.AutoSize = true;
            this.lblColorR.Location = new System.Drawing.Point(16, 31);
            this.lblColorR.Name = "lblColorR";
            this.lblColorR.Size = new System.Drawing.Size(26, 16);
            this.lblColorR.TabIndex = 0;
            this.lblColorR.Text = "R: ";
            // 
            // txtColorA
            // 
            this.txtColorA.Location = new System.Drawing.Point(495, 31);
            this.txtColorA.Name = "txtColorA";
            this.txtColorA.Size = new System.Drawing.Size(49, 27);
            this.txtColorA.TabIndex = 7;
            this.txtColorA.Validating += new System.ComponentModel.CancelEventHandler(this.txtColorA_Validating);
            // 
            // txtColorB
            // 
            this.txtColorB.Location = new System.Drawing.Point(335, 31);
            this.txtColorB.Name = "txtColorB";
            this.txtColorB.Size = new System.Drawing.Size(41, 27);
            this.txtColorB.TabIndex = 5;
            this.txtColorB.Validating += new System.ComponentModel.CancelEventHandler(this.txtColorB_Validating);
            // 
            // txtColorG
            // 
            this.txtColorG.Location = new System.Drawing.Point(197, 28);
            this.txtColorG.Name = "txtColorG";
            this.txtColorG.Size = new System.Drawing.Size(45, 27);
            this.txtColorG.TabIndex = 3;
            this.txtColorG.Validating += new System.ComponentModel.CancelEventHandler(this.txtColorG_Validating);
            // 
            // txtColorR
            // 
            this.txtColorR.Location = new System.Drawing.Point(55, 31);
            this.txtColorR.Name = "txtColorR";
            this.txtColorR.Size = new System.Drawing.Size(41, 27);
            this.txtColorR.TabIndex = 1;
            this.txtColorR.Validating += new System.ComponentModel.CancelEventHandler(this.txtColorR_Validating);
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMoney.Location = new System.Drawing.Point(420, 67);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(88, 16);
            this.lblMoney.TabIndex = 8;
            this.lblMoney.Text = "初始金錢：";
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtMoney.Location = new System.Drawing.Point(528, 64);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(100, 27);
            this.txtMoney.TabIndex = 9;
            this.txtMoney.Validating += new System.ComponentModel.CancelEventHandler(this.txtMoney_Validating);
            // 
            // lblIndustry
            // 
            this.lblIndustry.AutoSize = true;
            this.lblIndustry.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblIndustry.Location = new System.Drawing.Point(420, 123);
            this.lblIndustry.Name = "lblIndustry";
            this.lblIndustry.Size = new System.Drawing.Size(88, 16);
            this.lblIndustry.TabIndex = 10;
            this.lblIndustry.Text = "初始工業：";
            // 
            // txtIndustry
            // 
            this.txtIndustry.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtIndustry.Location = new System.Drawing.Point(528, 120);
            this.txtIndustry.Name = "txtIndustry";
            this.txtIndustry.Size = new System.Drawing.Size(100, 27);
            this.txtIndustry.TabIndex = 11;
            this.txtIndustry.Validating += new System.ComponentModel.CancelEventHandler(this.txtIndustry_Validating);
            // 
            // lblTechLevel
            // 
            this.lblTechLevel.AutoSize = true;
            this.lblTechLevel.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblTechLevel.Location = new System.Drawing.Point(420, 194);
            this.lblTechLevel.Name = "lblTechLevel";
            this.lblTechLevel.Size = new System.Drawing.Size(88, 16);
            this.lblTechLevel.TabIndex = 12;
            this.lblTechLevel.Text = "科技水平：";
            // 
            // txtTechLevel
            // 
            this.txtTechLevel.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtTechLevel.Location = new System.Drawing.Point(528, 193);
            this.txtTechLevel.Name = "txtTechLevel";
            this.txtTechLevel.Size = new System.Drawing.Size(100, 27);
            this.txtTechLevel.TabIndex = 13;
            this.txtTechLevel.Validating += new System.ComponentModel.CancelEventHandler(this.txtTechLevel_Validating);
            // 
            // grbAlliance
            // 
            this.grbAlliance.Controls.Add(this.rdbAllianceN);
            this.grbAlliance.Controls.Add(this.rdbAllianceC);
            this.grbAlliance.Controls.Add(this.rdbAllianceB);
            this.grbAlliance.Controls.Add(this.rdbAllianceA);
            this.grbAlliance.Font = new System.Drawing.Font("新細明體", 12F);
            this.grbAlliance.Location = new System.Drawing.Point(35, 249);
            this.grbAlliance.Name = "grbAlliance";
            this.grbAlliance.Size = new System.Drawing.Size(594, 80);
            this.grbAlliance.TabIndex = 16;
            this.grbAlliance.TabStop = false;
            this.grbAlliance.Text = "陣營";
            // 
            // rdbAllianceN
            // 
            this.rdbAllianceN.AutoSize = true;
            this.rdbAllianceN.Font = new System.Drawing.Font("新細明體", 12F);
            this.rdbAllianceN.Location = new System.Drawing.Point(464, 40);
            this.rdbAllianceN.Name = "rdbAllianceN";
            this.rdbAllianceN.Size = new System.Drawing.Size(58, 20);
            this.rdbAllianceN.TabIndex = 0;
            this.rdbAllianceN.TabStop = true;
            this.rdbAllianceN.Text = "中立";
            this.rdbAllianceN.UseVisualStyleBackColor = true;
            // 
            // rdbAllianceC
            // 
            this.rdbAllianceC.AutoSize = true;
            this.rdbAllianceC.Font = new System.Drawing.Font("新細明體", 12F);
            this.rdbAllianceC.Location = new System.Drawing.Point(302, 40);
            this.rdbAllianceC.Name = "rdbAllianceC";
            this.rdbAllianceC.Size = new System.Drawing.Size(58, 20);
            this.rdbAllianceC.TabIndex = 2;
            this.rdbAllianceC.TabStop = true;
            this.rdbAllianceC.Text = "紅色";
            this.rdbAllianceC.UseVisualStyleBackColor = true;
            // 
            // rdbAllianceB
            // 
            this.rdbAllianceB.AutoSize = true;
            this.rdbAllianceB.Font = new System.Drawing.Font("新細明體", 12F);
            this.rdbAllianceB.Location = new System.Drawing.Point(161, 40);
            this.rdbAllianceB.Name = "rdbAllianceB";
            this.rdbAllianceB.Size = new System.Drawing.Size(58, 20);
            this.rdbAllianceB.TabIndex = 1;
            this.rdbAllianceB.TabStop = true;
            this.rdbAllianceB.Text = "綠色";
            this.rdbAllianceB.UseVisualStyleBackColor = true;
            // 
            // rdbAllianceA
            // 
            this.rdbAllianceA.AutoSize = true;
            this.rdbAllianceA.Font = new System.Drawing.Font("新細明體", 12F);
            this.rdbAllianceA.Location = new System.Drawing.Point(19, 40);
            this.rdbAllianceA.Name = "rdbAllianceA";
            this.rdbAllianceA.Size = new System.Drawing.Size(58, 20);
            this.rdbAllianceA.TabIndex = 0;
            this.rdbAllianceA.TabStop = true;
            this.rdbAllianceA.Text = "藍色";
            this.rdbAllianceA.UseVisualStyleBackColor = true;
            // 
            // btnSaveCountry
            // 
            this.btnSaveCountry.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSaveCountry.Location = new System.Drawing.Point(554, 480);
            this.btnSaveCountry.Name = "btnSaveCountry";
            this.btnSaveCountry.Size = new System.Drawing.Size(108, 23);
            this.btnSaveCountry.TabIndex = 23;
            this.btnSaveCountry.Text = "儲存國家";
            this.btnSaveCountry.UseVisualStyleBackColor = true;
            this.btnSaveCountry.Click += new System.EventHandler(this.btnSaveCountry_Click);
            // 
            // cboCountryName
            // 
            this.cboCountryName.Font = new System.Drawing.Font("新細明體", 12F);
            this.cboCountryName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCountryName.FormattingEnabled = true;
            this.cboCountryName.Location = new System.Drawing.Point(135, 84);
            this.cboCountryName.Name = "cboCountryName";
            this.cboCountryName.Size = new System.Drawing.Size(121, 24);
            this.cboCountryName.TabIndex = 1;
            this.cboCountryName.Validating += new System.ComponentModel.CancelEventHandler(this.cboCountryName_Validating);
            // 
            // frmCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.cboCountryName);
            this.Controls.Add(this.btnSaveCountry);
            this.Controls.Add(this.grbAlliance);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.lblIndustry);
            this.Controls.Add(this.txtIndustry);
            this.Controls.Add(this.lblTechLevel);
            this.Controls.Add(this.txtTechLevel);
            this.Controls.Add(this.grbColor);
            this.Controls.Add(this.grbAIControl);
            this.Controls.Add(this.lblCountryName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCountry";
            this.Text = "國家設定";
            this.Load += new System.EventHandler(this.frmCountry_Load);
            this.grbAIControl.ResumeLayout(false);
            this.grbAIControl.PerformLayout();
            this.grbColor.ResumeLayout(false);
            this.grbColor.PerformLayout();
            this.grbAlliance.ResumeLayout(false);
            this.grbAlliance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountryName;
        private System.Windows.Forms.GroupBox grbAIControl;
        private System.Windows.Forms.RadioButton rdbAiYes;
        private System.Windows.Forms.RadioButton rdbAiNo;
        private System.Windows.Forms.GroupBox grbColor;
        private System.Windows.Forms.Label lblColorR;
        private System.Windows.Forms.TextBox txtColorA;
        private System.Windows.Forms.TextBox txtColorB;
        private System.Windows.Forms.TextBox txtColorG;
        private System.Windows.Forms.TextBox txtColorR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblColorB;
        private System.Windows.Forms.Label lblColorA;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblIndustry;
        private System.Windows.Forms.TextBox txtIndustry;
        private System.Windows.Forms.Label lblTechLevel;
        private System.Windows.Forms.TextBox txtTechLevel;
        private System.Windows.Forms.GroupBox grbAlliance;
        private System.Windows.Forms.RadioButton rdbAllianceN;
        private System.Windows.Forms.RadioButton rdbAllianceC;
        private System.Windows.Forms.RadioButton rdbAllianceB;
        private System.Windows.Forms.RadioButton rdbAllianceA;
        private System.Windows.Forms.Button btnSaveCountry;
        private System.Windows.Forms.ComboBox cboCountryName;
    }
}