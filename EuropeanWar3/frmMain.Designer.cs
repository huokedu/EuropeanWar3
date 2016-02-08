namespace EuropeanWar3
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnAddCountry = new System.Windows.Forms.Button();
            this.btnAddBattle = new System.Windows.Forms.Button();
            this.btnAddArmy = new System.Windows.Forms.Button();
            this.btnAddArea = new System.Windows.Forms.Button();
            this.openXMLFile = new System.Windows.Forms.OpenFileDialog();
            this.saveXMLFile = new System.Windows.Forms.SaveFileDialog();
            this.treBattle = new System.Windows.Forms.TreeView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTreeView = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCountry
            // 
            this.btnAddCountry.Location = new System.Drawing.Point(583, 136);
            this.btnAddCountry.Name = "btnAddCountry";
            this.btnAddCountry.Size = new System.Drawing.Size(75, 23);
            this.btnAddCountry.TabIndex = 2;
            this.btnAddCountry.Text = "新增國家";
            this.btnAddCountry.UseVisualStyleBackColor = true;
            this.btnAddCountry.Click += new System.EventHandler(this.btnAddCountry_Click);
            // 
            // btnAddBattle
            // 
            this.btnAddBattle.Location = new System.Drawing.Point(583, 88);
            this.btnAddBattle.Name = "btnAddBattle";
            this.btnAddBattle.Size = new System.Drawing.Size(75, 23);
            this.btnAddBattle.TabIndex = 1;
            this.btnAddBattle.Text = "戰役設定";
            this.btnAddBattle.UseVisualStyleBackColor = true;
            this.btnAddBattle.Click += new System.EventHandler(this.btnAddBattle_Click);
            // 
            // btnAddArmy
            // 
            this.btnAddArmy.Location = new System.Drawing.Point(583, 234);
            this.btnAddArmy.Name = "btnAddArmy";
            this.btnAddArmy.Size = new System.Drawing.Size(75, 23);
            this.btnAddArmy.TabIndex = 4;
            this.btnAddArmy.Text = "新增軍隊";
            this.btnAddArmy.UseVisualStyleBackColor = true;
            this.btnAddArmy.Click += new System.EventHandler(this.btnAddArmy_Click);
            // 
            // btnAddArea
            // 
            this.btnAddArea.Location = new System.Drawing.Point(583, 185);
            this.btnAddArea.Name = "btnAddArea";
            this.btnAddArea.Size = new System.Drawing.Size(75, 23);
            this.btnAddArea.TabIndex = 3;
            this.btnAddArea.Text = "新增地塊";
            this.btnAddArea.UseVisualStyleBackColor = true;
            this.btnAddArea.Click += new System.EventHandler(this.btnAddArea_Click);
            // 
            // treBattle
            // 
            this.treBattle.Location = new System.Drawing.Point(58, 88);
            this.treBattle.Name = "treBattle";
            this.treBattle.Size = new System.Drawing.Size(299, 430);
            this.treBattle.TabIndex = 8;
            this.treBattle.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treBattle_NodeMouseDoubleClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(583, 495);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "移除所選";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.RemoveNode);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "工具列";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.fileToolStripMenuItem.Text = "檔案";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.newToolStripMenuItem.Text = "新增戰役";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openToolStripMenuItem.Text = "讀取戰役";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.saveToolStripMenuItem.Text = "儲存戰役";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // lblTreeView
            // 
            this.lblTreeView.AutoSize = true;
            this.lblTreeView.Location = new System.Drawing.Point(56, 59);
            this.lblTreeView.Name = "lblTreeView";
            this.lblTreeView.Size = new System.Drawing.Size(53, 12);
            this.lblTreeView.TabIndex = 7;
            this.lblTreeView.Text = "戰役一覽";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(583, 448);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "刷新側欄";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.showTreeView);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblTreeView);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.treBattle);
            this.Controls.Add(this.btnAddArea);
            this.Controls.Add(this.btnAddArmy);
            this.Controls.Add(this.btnAddBattle);
            this.Controls.Add(this.btnAddCountry);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "歐三戰役編輯器";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCountry;
        private System.Windows.Forms.Button btnAddBattle;
        private System.Windows.Forms.Button btnAddArmy;
        private System.Windows.Forms.Button btnAddArea;
        private System.Windows.Forms.OpenFileDialog openXMLFile;
        private System.Windows.Forms.SaveFileDialog saveXMLFile;
        private System.Windows.Forms.TreeView treBattle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblTreeView;
        private System.Windows.Forms.Button btnSort;
    }
}