namespace JobManager
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpJobList = new System.Windows.Forms.TabPage();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lvJob = new System.Windows.Forms.ListView();
            this.btnDel = new System.Windows.Forms.Button();
            this.tpSubJobList = new System.Windows.Forms.TabPage();
            this.btnSubJobNew = new System.Windows.Forms.Button();
            this.btnSubJobEdit = new System.Windows.Forms.Button();
            this.btnSubJobDel = new System.Windows.Forms.Button();
            this.lvSubJobList = new System.Windows.Forms.ListView();
            this.lvJobShower = new System.Windows.Forms.ListView();
            this.tabMain.SuspendLayout();
            this.tpJobList.SuspendLayout();
            this.tpSubJobList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabMain.Controls.Add(this.tpJobList);
            this.tabMain.Controls.Add(this.tpSubJobList);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(732, 519);
            this.tabMain.TabIndex = 1;
            // 
            // tpJobList
            // 
            this.tpJobList.Controls.Add(this.btnNew);
            this.tpJobList.Controls.Add(this.btnEdit);
            this.tpJobList.Controls.Add(this.lvJob);
            this.tpJobList.Controls.Add(this.btnDel);
            this.tpJobList.Location = new System.Drawing.Point(4, 22);
            this.tpJobList.Name = "tpJobList";
            this.tpJobList.Padding = new System.Windows.Forms.Padding(3);
            this.tpJobList.Size = new System.Drawing.Size(724, 493);
            this.tpJobList.TabIndex = 0;
            this.tpJobList.Text = "业务";
            this.tpJobList.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Location = new System.Drawing.Point(487, 449);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(73, 38);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "新增(&A)";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(566, 449);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(73, 38);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "修改(&E)";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lvJob
            // 
            this.lvJob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvJob.CheckBoxes = true;
            this.lvJob.HideSelection = false;
            this.lvJob.Location = new System.Drawing.Point(6, 6);
            this.lvJob.MultiSelect = false;
            this.lvJob.Name = "lvJob";
            this.lvJob.Size = new System.Drawing.Size(712, 437);
            this.lvJob.TabIndex = 2;
            this.lvJob.UseCompatibleStateImageBehavior = false;
            this.lvJob.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvJob_ItemCheck);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(645, 449);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(73, 38);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "删除（&D)";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tpSubJobList
            // 
            this.tpSubJobList.Controls.Add(this.btnSubJobNew);
            this.tpSubJobList.Controls.Add(this.btnSubJobEdit);
            this.tpSubJobList.Controls.Add(this.btnSubJobDel);
            this.tpSubJobList.Controls.Add(this.lvSubJobList);
            this.tpSubJobList.Controls.Add(this.lvJobShower);
            this.tpSubJobList.Location = new System.Drawing.Point(4, 22);
            this.tpSubJobList.Name = "tpSubJobList";
            this.tpSubJobList.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubJobList.Size = new System.Drawing.Size(724, 493);
            this.tpSubJobList.TabIndex = 1;
            this.tpSubJobList.Text = "步骤";
            this.tpSubJobList.UseVisualStyleBackColor = true;
            // 
            // btnSubJobNew
            // 
            this.btnSubJobNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubJobNew.Location = new System.Drawing.Point(495, 449);
            this.btnSubJobNew.Name = "btnSubJobNew";
            this.btnSubJobNew.Size = new System.Drawing.Size(73, 38);
            this.btnSubJobNew.TabIndex = 9;
            this.btnSubJobNew.Text = "新增步骤(&Z)";
            this.btnSubJobNew.UseVisualStyleBackColor = true;
            this.btnSubJobNew.Click += new System.EventHandler(this.btnSubJobNew_Click);
            // 
            // btnSubJobEdit
            // 
            this.btnSubJobEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubJobEdit.Location = new System.Drawing.Point(574, 449);
            this.btnSubJobEdit.Name = "btnSubJobEdit";
            this.btnSubJobEdit.Size = new System.Drawing.Size(73, 38);
            this.btnSubJobEdit.TabIndex = 8;
            this.btnSubJobEdit.Text = "修改步骤(&X)";
            this.btnSubJobEdit.UseVisualStyleBackColor = true;
            this.btnSubJobEdit.Click += new System.EventHandler(this.btnSubJobEdit_Click);
            // 
            // btnSubJobDel
            // 
            this.btnSubJobDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubJobDel.Location = new System.Drawing.Point(653, 449);
            this.btnSubJobDel.Name = "btnSubJobDel";
            this.btnSubJobDel.Size = new System.Drawing.Size(65, 38);
            this.btnSubJobDel.TabIndex = 7;
            this.btnSubJobDel.Text = "删除步骤（&S)";
            this.btnSubJobDel.UseVisualStyleBackColor = true;
            this.btnSubJobDel.Click += new System.EventHandler(this.btnSubJobDel_Click);
            // 
            // lvSubJobList
            // 
            this.lvSubJobList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvSubJobList.CheckBoxes = true;
            this.lvSubJobList.HideSelection = false;
            this.lvSubJobList.Location = new System.Drawing.Point(6, 280);
            this.lvSubJobList.MultiSelect = false;
            this.lvSubJobList.Name = "lvSubJobList";
            this.lvSubJobList.Size = new System.Drawing.Size(712, 163);
            this.lvSubJobList.TabIndex = 4;
            this.lvSubJobList.UseCompatibleStateImageBehavior = false;
            this.lvSubJobList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvSubJobList_ItemCheck);
            // 
            // lvJobShower
            // 
            this.lvJobShower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvJobShower.CheckBoxes = true;
            this.lvJobShower.HideSelection = false;
            this.lvJobShower.Location = new System.Drawing.Point(6, 6);
            this.lvJobShower.MultiSelect = false;
            this.lvJobShower.Name = "lvJobShower";
            this.lvJobShower.Size = new System.Drawing.Size(712, 268);
            this.lvJobShower.TabIndex = 3;
            this.lvJobShower.UseCompatibleStateImageBehavior = false;
            this.lvJobShower.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lvJobShower_ItemCheck);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 543);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "业务信息管理";
            this.tabMain.ResumeLayout(false);
            this.tpJobList.ResumeLayout(false);
            this.tpSubJobList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpJobList;
        private System.Windows.Forms.TabPage tpSubJobList;
        private System.Windows.Forms.ListView lvJob;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSubJobNew;
        private System.Windows.Forms.Button btnSubJobEdit;
        private System.Windows.Forms.Button btnSubJobDel;
        private System.Windows.Forms.ListView lvSubJobList;
        private System.Windows.Forms.ListView lvJobShower;
    }
}

