namespace MountainSearchApp
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabMoun = new MetroFramework.Controls.MetroLabel();
            this.TxtMounName = new MetroFramework.Controls.MetroTextBox();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.GridMoun = new MetroFramework.Controls.MetroGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntnnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntninfopoflc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntninfohght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CboArea = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CboSeason = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TxtMounInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMounInfo = new System.Windows.Forms.TabPage();
            this.GroupInfo2 = new System.Windows.Forms.GroupBox();
            this.TxtMounInfo2 = new System.Windows.Forms.TextBox();
            this.GroupInfo = new System.Windows.Forms.GroupBox();
            this.TabTraffic = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtTraffic = new System.Windows.Forms.TextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtTour = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridMoun)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabMounInfo.SuspendLayout();
            this.GroupInfo2.SuspendLayout();
            this.GroupInfo.SuspendLayout();
            this.TabTraffic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabMoun
            // 
            this.LabMoun.AutoSize = true;
            this.LabMoun.Location = new System.Drawing.Point(38, 127);
            this.LabMoun.Name = "LabMoun";
            this.LabMoun.Size = new System.Drawing.Size(66, 19);
            this.LabMoun.TabIndex = 0;
            this.LabMoun.Text = "산 이름 : ";
            // 
            // TxtMounName
            // 
            // 
            // 
            // 
            this.TxtMounName.CustomButton.Image = null;
            this.TxtMounName.CustomButton.Location = new System.Drawing.Point(199, 1);
            this.TxtMounName.CustomButton.Name = "";
            this.TxtMounName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMounName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMounName.CustomButton.TabIndex = 1;
            this.TxtMounName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMounName.CustomButton.UseSelectable = true;
            this.TxtMounName.CustomButton.Visible = false;
            this.TxtMounName.Lines = new string[0];
            this.TxtMounName.Location = new System.Drawing.Point(99, 123);
            this.TxtMounName.MaxLength = 32767;
            this.TxtMounName.Name = "TxtMounName";
            this.TxtMounName.PasswordChar = '\0';
            this.TxtMounName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMounName.SelectedText = "";
            this.TxtMounName.SelectionLength = 0;
            this.TxtMounName.SelectionStart = 0;
            this.TxtMounName.ShortcutsEnabled = true;
            this.TxtMounName.Size = new System.Drawing.Size(221, 23);
            this.TxtMounName.TabIndex = 0;
            this.TxtMounName.UseSelectable = true;
            this.TxtMounName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMounName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(326, 123);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(86, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "검색";
            this.BtnSearch.UseSelectable = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // GridMoun
            // 
            this.GridMoun.AllowUserToAddRows = false;
            this.GridMoun.AllowUserToDeleteRows = false;
            this.GridMoun.AllowUserToResizeColumns = false;
            this.GridMoun.AllowUserToResizeRows = false;
            this.GridMoun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridMoun.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.GridMoun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMoun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMoun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridMoun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMoun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridMoun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMoun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.mntnnm,
            this.mntninfopoflc,
            this.mntninfohght});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMoun.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridMoun.EnableHeadersVisualStyles = false;
            this.GridMoun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridMoun.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMoun.Location = new System.Drawing.Point(38, 182);
            this.GridMoun.Name = "GridMoun";
            this.GridMoun.ReadOnly = true;
            this.GridMoun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMoun.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridMoun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridMoun.RowTemplate.Height = 23;
            this.GridMoun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMoun.Size = new System.Drawing.Size(469, 488);
            this.GridMoun.Style = MetroFramework.MetroColorStyle.Green;
            this.GridMoun.TabIndex = 2;
            this.GridMoun.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GridMoun.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMoun_CellDoubleClick);
            // 
            // No
            // 
            this.No.HeaderText = "번호";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // mntnnm
            // 
            this.mntnnm.HeaderText = "산 이름";
            this.mntnnm.Name = "mntnnm";
            this.mntnnm.ReadOnly = true;
            // 
            // mntninfopoflc
            // 
            this.mntninfopoflc.HeaderText = "지역";
            this.mntninfopoflc.Name = "mntninfopoflc";
            this.mntninfopoflc.ReadOnly = true;
            // 
            // mntninfohght
            // 
            this.mntninfohght.HeaderText = "높이(m)";
            this.mntninfohght.Name = "mntninfohght";
            this.mntninfohght.ReadOnly = true;
            // 
            // CboArea
            // 
            this.CboArea.FormattingEnabled = true;
            this.CboArea.ItemHeight = 23;
            this.CboArea.Location = new System.Drawing.Point(110, 85);
            this.CboArea.Name = "CboArea";
            this.CboArea.Size = new System.Drawing.Size(121, 29);
            this.CboArea.TabIndex = 3;
            this.CboArea.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(56, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "지역 : ";
            // 
            // CboSeason
            // 
            this.CboSeason.FormattingEnabled = true;
            this.CboSeason.ItemHeight = 23;
            this.CboSeason.Location = new System.Drawing.Point(291, 85);
            this.CboSeason.Name = "CboSeason";
            this.CboSeason.Size = new System.Drawing.Size(121, 29);
            this.CboSeason.TabIndex = 3;
            this.CboSeason.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(237, 95);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "계절 : ";
            // 
            // TxtMounInfo
            // 
            this.TxtMounInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMounInfo.Location = new System.Drawing.Point(3, 17);
            this.TxtMounInfo.Multiline = true;
            this.TxtMounInfo.Name = "TxtMounInfo";
            this.TxtMounInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMounInfo.Size = new System.Drawing.Size(685, 233);
            this.TxtMounInfo.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabMounInfo);
            this.tabControl1.Controls.Add(this.TabTraffic);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(553, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(711, 611);
            this.tabControl1.TabIndex = 6;
            // 
            // TabMounInfo
            // 
            this.TabMounInfo.Controls.Add(this.GroupInfo2);
            this.TabMounInfo.Controls.Add(this.GroupInfo);
            this.TabMounInfo.Location = new System.Drawing.Point(4, 22);
            this.TabMounInfo.Name = "TabMounInfo";
            this.TabMounInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TabMounInfo.Size = new System.Drawing.Size(703, 585);
            this.TabMounInfo.TabIndex = 0;
            this.TabMounInfo.Text = "산 정보";
            this.TabMounInfo.UseVisualStyleBackColor = true;
            // 
            // GroupInfo2
            // 
            this.GroupInfo2.Controls.Add(this.TxtMounInfo2);
            this.GroupInfo2.Location = new System.Drawing.Point(6, 265);
            this.GroupInfo2.Name = "GroupInfo2";
            this.GroupInfo2.Size = new System.Drawing.Size(688, 314);
            this.GroupInfo2.TabIndex = 1;
            this.GroupInfo2.TabStop = false;
            this.GroupInfo2.Text = "100대명산 선정이유";
            // 
            // TxtMounInfo2
            // 
            this.TxtMounInfo2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMounInfo2.Location = new System.Drawing.Point(3, 17);
            this.TxtMounInfo2.Multiline = true;
            this.TxtMounInfo2.Name = "TxtMounInfo2";
            this.TxtMounInfo2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtMounInfo2.Size = new System.Drawing.Size(682, 294);
            this.TxtMounInfo2.TabIndex = 0;
            // 
            // GroupInfo
            // 
            this.GroupInfo.Controls.Add(this.TxtMounInfo);
            this.GroupInfo.Location = new System.Drawing.Point(6, 6);
            this.GroupInfo.Name = "GroupInfo";
            this.GroupInfo.Size = new System.Drawing.Size(691, 253);
            this.GroupInfo.TabIndex = 0;
            this.GroupInfo.TabStop = false;
            this.GroupInfo.Text = "산 상세정보";
            // 
            // TabTraffic
            // 
            this.TabTraffic.Controls.Add(this.splitContainer1);
            this.TabTraffic.Location = new System.Drawing.Point(4, 22);
            this.TabTraffic.Name = "TabTraffic";
            this.TabTraffic.Padding = new System.Windows.Forms.Padding(3);
            this.TabTraffic.Size = new System.Drawing.Size(703, 585);
            this.TabTraffic.TabIndex = 1;
            this.TabTraffic.Text = "교통/관광 정보";
            this.TabTraffic.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TxtTraffic);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtTour);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel4);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(697, 579);
            this.splitContainer1.SplitterDistance = 269;
            this.splitContainer1.TabIndex = 0;
            // 
            // TxtTraffic
            // 
            this.TxtTraffic.Location = new System.Drawing.Point(12, 33);
            this.TxtTraffic.Multiline = true;
            this.TxtTraffic.Name = "TxtTraffic";
            this.TxtTraffic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTraffic.Size = new System.Drawing.Size(671, 233);
            this.TxtTraffic.TabIndex = 1;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(69, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "교통 정보";
            // 
            // TxtTour
            // 
            this.TxtTour.Location = new System.Drawing.Point(12, 32);
            this.TxtTour.Multiline = true;
            this.TxtTour.Name = "TxtTour";
            this.TxtTour.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtTour.Size = new System.Drawing.Size(671, 233);
            this.TxtTour.TabIndex = 1;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(12, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "관광 정보";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(38, 160);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(156, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "*정보 보기(Double Click)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 691);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.CboSeason);
            this.Controls.Add(this.CboArea);
            this.Controls.Add(this.GridMoun);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtMounName);
            this.Controls.Add(this.LabMoun);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "산 정보 찾기";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridMoun)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabMounInfo.ResumeLayout(false);
            this.GroupInfo2.ResumeLayout(false);
            this.GroupInfo2.PerformLayout();
            this.GroupInfo.ResumeLayout(false);
            this.GroupInfo.PerformLayout();
            this.TabTraffic.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LabMoun;
        private MetroFramework.Controls.MetroTextBox TxtMounName;
        private MetroFramework.Controls.MetroButton BtnSearch;
        private MetroFramework.Controls.MetroGrid GridMoun;
        private MetroFramework.Controls.MetroComboBox CboArea;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox CboSeason;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.TextBox TxtMounInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMounInfo;
        private System.Windows.Forms.TabPage TabTraffic;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntnnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntninfopoflc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntninfohght;
        private System.Windows.Forms.GroupBox GroupInfo2;
        private System.Windows.Forms.TextBox TxtMounInfo2;
        private System.Windows.Forms.GroupBox GroupInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtTraffic;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.TextBox TxtTour;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}

