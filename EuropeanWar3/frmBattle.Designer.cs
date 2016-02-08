namespace EuropeanWar3
{
    partial class frmBattle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBattle));
            this.lblBattleName = new System.Windows.Forms.Label();
            this.txtBattleName = new System.Windows.Forms.TextBox();
            this.btnSaveBattle = new System.Windows.Forms.Button();
            this.txtMap = new System.Windows.Forms.TextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBattleName
            // 
            this.lblBattleName.AutoSize = true;
            this.lblBattleName.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblBattleName.Location = new System.Drawing.Point(180, 228);
            this.lblBattleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattleName.Name = "lblBattleName";
            this.lblBattleName.Size = new System.Drawing.Size(76, 16);
            this.lblBattleName.TabIndex = 1;
            this.lblBattleName.Text = "檔案名稱:";
            // 
            // txtBattleName
            // 
            this.txtBattleName.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtBattleName.Location = new System.Drawing.Point(351, 225);
            this.txtBattleName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBattleName.Name = "txtBattleName";
            this.txtBattleName.Size = new System.Drawing.Size(148, 27);
            this.txtBattleName.TabIndex = 2;
            // 
            // btnSaveBattle
            // 
            this.btnSaveBattle.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSaveBattle.Location = new System.Drawing.Point(387, 391);
            this.btnSaveBattle.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBattle.Name = "btnSaveBattle";
            this.btnSaveBattle.Size = new System.Drawing.Size(112, 31);
            this.btnSaveBattle.TabIndex = 3;
            this.btnSaveBattle.Text = "儲存設定";
            this.btnSaveBattle.UseVisualStyleBackColor = true;
            this.btnSaveBattle.Click += new System.EventHandler(this.btnSaveBattle_Click);
            // 
            // txtMap
            // 
            this.txtMap.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtMap.Location = new System.Drawing.Point(351, 137);
            this.txtMap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMap.Name = "txtMap";
            this.txtMap.Size = new System.Drawing.Size(148, 27);
            this.txtMap.TabIndex = 5;
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMap.Location = new System.Drawing.Point(180, 140);
            this.lblMap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(76, 16);
            this.lblMap.TabIndex = 4;
            this.lblMap.Text = "地圖號碼:";
            // 
            // frmBattle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.txtMap);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.btnSaveBattle);
            this.Controls.Add(this.txtBattleName);
            this.Controls.Add(this.lblBattleName);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBattle";
            this.Text = "戰爭設定";
            this.Load += new System.EventHandler(this.frmBattle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBattleName;
        private System.Windows.Forms.TextBox txtBattleName;
        private System.Windows.Forms.Button btnSaveBattle;
        private System.Windows.Forms.TextBox txtMap;
        private System.Windows.Forms.Label lblMap;
    }
}