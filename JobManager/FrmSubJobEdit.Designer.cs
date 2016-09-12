namespace JobManager
{
    partial class FrmSubJobEdit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cbPostId = new System.Windows.Forms.ComboBox();
            this.cbStepType = new System.Windows.Forms.ComboBox();
            this.lblStepPostId = new System.Windows.Forms.Label();
            this.lblStepType = new System.Windows.Forms.Label();
            this.lblStepText = new System.Windows.Forms.Label();
            this.lblStepName = new System.Windows.Forms.Label();
            this.txtStepText = new System.Windows.Forms.TextBox();
            this.txtStepName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(430, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 41);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "保存(&S)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(518, 145);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 41);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "关闭(&C)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cbPostId
            // 
            this.cbPostId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPostId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPostId.FormattingEnabled = true;
            this.cbPostId.Location = new System.Drawing.Point(138, 107);
            this.cbPostId.Name = "cbPostId";
            this.cbPostId.Size = new System.Drawing.Size(462, 20);
            this.cbPostId.TabIndex = 29;
            // 
            // cbStepType
            // 
            this.cbStepType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStepType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStepType.FormattingEnabled = true;
            this.cbStepType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStepType.Location = new System.Drawing.Point(138, 81);
            this.cbStepType.Name = "cbStepType";
            this.cbStepType.Size = new System.Drawing.Size(462, 20);
            this.cbStepType.TabIndex = 28;
            // 
            // lblStepPostId
            // 
            this.lblStepPostId.AutoSize = true;
            this.lblStepPostId.Location = new System.Drawing.Point(12, 110);
            this.lblStepPostId.Name = "lblStepPostId";
            this.lblStepPostId.Size = new System.Drawing.Size(77, 12);
            this.lblStepPostId.TabIndex = 33;
            this.lblStepPostId.Text = "导航位置编号";
            // 
            // lblStepType
            // 
            this.lblStepType.AutoSize = true;
            this.lblStepType.Location = new System.Drawing.Point(12, 83);
            this.lblStepType.Name = "lblStepType";
            this.lblStepType.Size = new System.Drawing.Size(53, 12);
            this.lblStepType.TabIndex = 32;
            this.lblStepType.Text = "步骤类型";
            // 
            // lblStepText
            // 
            this.lblStepText.AutoSize = true;
            this.lblStepText.Location = new System.Drawing.Point(12, 56);
            this.lblStepText.Name = "lblStepText";
            this.lblStepText.Size = new System.Drawing.Size(53, 12);
            this.lblStepText.TabIndex = 31;
            this.lblStepText.Text = "步骤描述";
            // 
            // lblStepName
            // 
            this.lblStepName.AutoSize = true;
            this.lblStepName.Location = new System.Drawing.Point(12, 29);
            this.lblStepName.Name = "lblStepName";
            this.lblStepName.Size = new System.Drawing.Size(53, 12);
            this.lblStepName.TabIndex = 30;
            this.lblStepName.Text = "步骤名称";
            // 
            // txtStepText
            // 
            this.txtStepText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepText.Location = new System.Drawing.Point(138, 53);
            this.txtStepText.Name = "txtStepText";
            this.txtStepText.Size = new System.Drawing.Size(462, 21);
            this.txtStepText.TabIndex = 27;
            // 
            // txtStepName
            // 
            this.txtStepName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStepName.Location = new System.Drawing.Point(138, 26);
            this.txtStepName.Name = "txtStepName";
            this.txtStepName.Size = new System.Drawing.Size(462, 21);
            this.txtStepName.TabIndex = 26;
            // 
            // FrmSubJobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 196);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbPostId);
            this.Controls.Add(this.cbStepType);
            this.Controls.Add(this.lblStepPostId);
            this.Controls.Add(this.lblStepType);
            this.Controls.Add(this.lblStepText);
            this.Controls.Add(this.lblStepName);
            this.Controls.Add(this.txtStepText);
            this.Controls.Add(this.txtStepName);
            this.Name = "FrmSubJobEdit";
            this.Text = "修改步骤信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbPostId;
        private System.Windows.Forms.ComboBox cbStepType;
        private System.Windows.Forms.Label lblStepPostId;
        private System.Windows.Forms.Label lblStepType;
        private System.Windows.Forms.Label lblStepText;
        private System.Windows.Forms.Label lblStepName;
        private System.Windows.Forms.TextBox txtStepText;
        private System.Windows.Forms.TextBox txtStepName;
    }
}