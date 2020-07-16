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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LabMoun = new MetroFramework.Controls.MetroLabel();
            this.TxtMounName = new MetroFramework.Controls.MetroTextBox();
            this.BtnSearch = new MetroFramework.Controls.MetroButton();
            this.GridMoun = new MetroFramework.Controls.MetroGrid();
            this.CboArea = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CboSeason = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntnnm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntninfopoflc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mntninfohght = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridMoun)).BeginInit();
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
            this.GridMoun.AllowUserToResizeRows = false;
            this.GridMoun.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridMoun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridMoun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridMoun.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMoun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridMoun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMoun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.mntnnm,
            this.mntninfopoflc,
            this.mntninfohght});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridMoun.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridMoun.EnableHeadersVisualStyles = false;
            this.GridMoun.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridMoun.GridColor = System.Drawing.Color.Silver;
            this.GridMoun.Location = new System.Drawing.Point(38, 152);
            this.GridMoun.Name = "GridMoun";
            this.GridMoun.ReadOnly = true;
            this.GridMoun.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridMoun.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridMoun.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridMoun.RowTemplate.Height = 23;
            this.GridMoun.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridMoun.Size = new System.Drawing.Size(555, 518);
            this.GridMoun.Style = MetroFramework.MetroColorStyle.Green;
            this.GridMoun.TabIndex = 2;
            this.GridMoun.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.mntninfopoflc.Width = 250;
            // 
            // mntninfohght
            // 
            this.mntninfohght.HeaderText = "높이(m)";
            this.mntninfohght.Name = "mntninfohght";
            this.mntninfohght.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 801);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntnnm;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntninfopoflc;
        private System.Windows.Forms.DataGridViewTextBoxColumn mntninfohght;
    }
}

