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
            this.btnSave = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tpJobList = new System.Windows.Forms.TabPage();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.lblSN = new System.Windows.Forms.Label();
            this.lvJob = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tpSubJobList = new System.Windows.Forms.TabPage();
            this.tabMain.SuspendLayout();
            this.tpJobList.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(553, 380);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(73, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpJobList);
            this.tabMain.Controls.Add(this.tpSubJobList);
            this.tabMain.Location = new System.Drawing.Point(12, 12);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(640, 450);
            this.tabMain.TabIndex = 1;
            // 
            // tpJobList
            // 
            this.tpJobList.Controls.Add(this.txtSN);
            this.tpJobList.Controls.Add(this.lblSN);
            this.tpJobList.Controls.Add(this.lvJob);
            this.tpJobList.Controls.Add(this.btnRefresh);
            this.tpJobList.Controls.Add(this.btnSave);
            this.tpJobList.Location = new System.Drawing.Point(4, 22);
            this.tpJobList.Name = "tpJobList";
            this.tpJobList.Padding = new System.Windows.Forms.Padding(3);
            this.tpJobList.Size = new System.Drawing.Size(632, 424);
            this.tpJobList.TabIndex = 0;
            this.tpJobList.Text = "业务";
            this.tpJobList.UseVisualStyleBackColor = true;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(47, 341);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(78, 21);
            this.txtSN.TabIndex = 4;
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(12, 344);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(29, 12);
            this.lblSN.TabIndex = 3;
            this.lblSN.Text = "序号";
            // 
            // lvJob
            // 
            this.lvJob.Location = new System.Drawing.Point(6, 6);
            this.lvJob.Name = "lvJob";
            this.lvJob.Size = new System.Drawing.Size(620, 312);
            this.lvJob.TabIndex = 2;
            this.lvJob.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(474, 380);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 38);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tpSubJobList
            // 
            this.tpSubJobList.Location = new System.Drawing.Point(4, 22);
            this.tpSubJobList.Name = "tpSubJobList";
            this.tpSubJobList.Padding = new System.Windows.Forms.Padding(3);
            this.tpSubJobList.Size = new System.Drawing.Size(632, 424);
            this.tpSubJobList.TabIndex = 1;
            this.tpSubJobList.Text = "步骤";
            this.tpSubJobList.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 474);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "业务信息管理";
            this.tabMain.ResumeLayout(false);
            this.tpJobList.ResumeLayout(false);
            this.tpJobList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tpJobList;
        private System.Windows.Forms.TabPage tpSubJobList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView lvJob;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label lblSN;
    }
}

