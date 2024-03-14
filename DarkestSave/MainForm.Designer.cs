namespace DarkestSave
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.btnSelectSavePath = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridSaveFile = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSaveLocation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reName = new System.Windows.Forms.ToolStripMenuItem();
            this.readSave = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaveFile)).BeginInit();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.Location = new System.Drawing.Point(12, 12);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(328, 21);
            this.txtSavePath.TabIndex = 0;
            // 
            // btnSelectSavePath
            // 
            this.btnSelectSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectSavePath.Location = new System.Drawing.Point(346, 12);
            this.btnSelectSavePath.Name = "btnSelectSavePath";
            this.btnSelectSavePath.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSavePath.TabIndex = 1;
            this.btnSelectSavePath.Text = "选择目录";
            this.btnSelectSavePath.UseVisualStyleBackColor = true;
            this.btnSelectSavePath.Click += new System.EventHandler(this.btnSelectSavePath_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dataGridSaveFile);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 319);
            this.panel1.TabIndex = 2;
            // 
            // dataGridSaveFile
            // 
            this.dataGridSaveFile.AllowUserToAddRows = false;
            this.dataGridSaveFile.AllowUserToResizeColumns = false;
            this.dataGridSaveFile.AllowUserToResizeRows = false;
            this.dataGridSaveFile.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSaveFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSaveFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.CreateTime,
            this.FilePath});
            this.dataGridSaveFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridSaveFile.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridSaveFile.Location = new System.Drawing.Point(0, 41);
            this.dataGridSaveFile.Name = "dataGridSaveFile";
            this.dataGridSaveFile.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridSaveFile.RowTemplate.Height = 23;
            this.dataGridSaveFile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSaveFile.Size = new System.Drawing.Size(409, 278);
            this.dataGridSaveFile.TabIndex = 3;
            this.dataGridSaveFile.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridSaveFile_CellBeginEdit);
            this.dataGridSaveFile.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSaveFile_CellEndEdit);
            this.dataGridSaveFile.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridSaveFile_CellMouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.cbSaveLocation);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 41);
            this.panel2.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(321, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "添加存档";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSaveLocation
            // 
            this.cbSaveLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSaveLocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbSaveLocation.FormattingEnabled = true;
            this.cbSaveLocation.ItemHeight = 16;
            this.cbSaveLocation.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbSaveLocation.Location = new System.Drawing.Point(73, 8);
            this.cbSaveLocation.Name = "cbSaveLocation";
            this.cbSaveLocation.Size = new System.Drawing.Size(75, 24);
            this.cbSaveLocation.TabIndex = 7;
            this.cbSaveLocation.SelectedIndexChanged += new System.EventHandler(this.cbSaveLocation_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "存档位：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reName,
            this.readSave,
            this.deleteSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // reName
            // 
            this.reName.Name = "reName";
            this.reName.Size = new System.Drawing.Size(124, 22);
            this.reName.Text = "重命名";
            this.reName.Click += new System.EventHandler(this.reName_Click);
            // 
            // readSave
            // 
            this.readSave.Name = "readSave";
            this.readSave.Size = new System.Drawing.Size(124, 22);
            this.readSave.Text = "读取存档";
            this.readSave.Click += new System.EventHandler(this.readSave_Click);
            // 
            // deleteSave
            // 
            this.deleteSave.Name = "deleteSave";
            this.deleteSave.Size = new System.Drawing.Size(124, 22);
            this.deleteSave.Text = "删除存档";
            this.deleteSave.Click += new System.EventHandler(this.deleteSave_Click);
            // 
            // FileName
            // 
            this.FileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FileName.DataPropertyName = "FileName";
            this.FileName.FillWeight = 66F;
            this.FileName.HeaderText = "存档名";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 34F;
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // FilePath
            // 
            this.FilePath.DataPropertyName = "FilePath";
            this.FilePath.HeaderText = "文件路径";
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSelectSavePath);
            this.Controls.Add(this.txtSavePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "暗黑地牢存档工具";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSaveFile)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.Button btnSelectSavePath;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridSaveFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem readSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbSaveLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem deleteSave;
        private System.Windows.Forms.ToolStripMenuItem reName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
    }
}

