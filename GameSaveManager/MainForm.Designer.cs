namespace GameSaveManager
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbTarget = new System.Windows.Forms.TextBox();
            this.scContent = new System.Windows.Forms.SplitContainer();
            this.lvList = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbRemark = new System.Windows.Forms.GroupBox();
            this.tbRemark = new System.Windows.Forms.TextBox();
            this.gbName = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).BeginInit();
            this.scContent.Panel1.SuspendLayout();
            this.scContent.Panel2.SuspendLayout();
            this.scContent.SuspendLayout();
            this.gbRemark.SuspendLayout();
            this.gbName.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.btnSelect);
            this.gbTarget.Controls.Add(this.tbTarget);
            this.gbTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTarget.Location = new System.Drawing.Point(20, 20);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.gbTarget.Size = new System.Drawing.Size(760, 75);
            this.gbTarget.TabIndex = 0;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target";
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSelect.Location = new System.Drawing.Point(665, 28);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 27);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.SelectTarget);
            // 
            // tbTarget
            // 
            this.tbTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTarget.Location = new System.Drawing.Point(20, 28);
            this.tbTarget.Name = "tbTarget";
            this.tbTarget.Size = new System.Drawing.Size(639, 25);
            this.tbTarget.TabIndex = 0;
            this.tbTarget.DoubleClick += new System.EventHandler(this.SelectTarget);
            this.tbTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTarget_KeyPress);
            // 
            // scContent
            // 
            this.scContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scContent.Enabled = false;
            this.scContent.Location = new System.Drawing.Point(20, 95);
            this.scContent.Name = "scContent";
            // 
            // scContent.Panel1
            // 
            this.scContent.Panel1.Controls.Add(this.lvList);
            this.scContent.Panel1.Controls.Add(this.btnBackup);
            this.scContent.Panel1.Padding = new System.Windows.Forms.Padding(0, 20, 10, 0);
            // 
            // scContent.Panel2
            // 
            this.scContent.Panel2.Controls.Add(this.btnRestore);
            this.scContent.Panel2.Controls.Add(this.btnDelete);
            this.scContent.Panel2.Controls.Add(this.btnSave);
            this.scContent.Panel2.Controls.Add(this.gbRemark);
            this.scContent.Panel2.Controls.Add(this.gbName);
            this.scContent.Panel2.Enabled = false;
            this.scContent.Panel2.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.scContent.Size = new System.Drawing.Size(760, 335);
            this.scContent.SplitterDistance = 256;
            this.scContent.TabIndex = 1;
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName});
            this.lvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvList.FullRowSelect = true;
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(0, 20);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(246, 265);
            this.lvList.TabIndex = 3;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            this.lvList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvList_ItemSelectionChanged);
            // 
            // chName
            // 
            this.chName.Text = "Name";
            // 
            // btnBackup
            // 
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBackup.Location = new System.Drawing.Point(0, 285);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(246, 50);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRestore.Location = new System.Drawing.Point(205, 285);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(195, 50);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(400, 285);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 50);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(10, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gbRemark
            // 
            this.gbRemark.Controls.Add(this.tbRemark);
            this.gbRemark.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbRemark.Location = new System.Drawing.Point(10, 85);
            this.gbRemark.Name = "gbRemark";
            this.gbRemark.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.gbRemark.Size = new System.Drawing.Size(490, 200);
            this.gbRemark.TabIndex = 2;
            this.gbRemark.TabStop = false;
            this.gbRemark.Text = "Remark";
            // 
            // tbRemark
            // 
            this.tbRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRemark.Location = new System.Drawing.Point(20, 28);
            this.tbRemark.Multiline = true;
            this.tbRemark.Name = "tbRemark";
            this.tbRemark.Size = new System.Drawing.Size(450, 152);
            this.tbRemark.TabIndex = 0;
            // 
            // gbName
            // 
            this.gbName.Controls.Add(this.lblTime);
            this.gbName.Controls.Add(this.tbName);
            this.gbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbName.Location = new System.Drawing.Point(10, 10);
            this.gbName.Name = "gbName";
            this.gbName.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.gbName.Size = new System.Drawing.Size(490, 75);
            this.gbName.TabIndex = 0;
            this.gbName.TabStop = false;
            this.gbName.Text = "Name";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(20, 56);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 15);
            this.lblTime.TabIndex = 1;
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbName.Location = new System.Drawing.Point(20, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(450, 25);
            this.tbName.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scContent);
            this.Controls.Add(this.gbTarget);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Save Manager";
            this.gbTarget.ResumeLayout(false);
            this.gbTarget.PerformLayout();
            this.scContent.Panel1.ResumeLayout(false);
            this.scContent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scContent)).EndInit();
            this.scContent.ResumeLayout(false);
            this.gbRemark.ResumeLayout(false);
            this.gbRemark.PerformLayout();
            this.gbName.ResumeLayout(false);
            this.gbName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbTarget;
        private System.Windows.Forms.SplitContainer scContent;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbRemark;
        private System.Windows.Forms.GroupBox gbName;
        private System.Windows.Forms.TextBox tbRemark;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTime;
    }
}

