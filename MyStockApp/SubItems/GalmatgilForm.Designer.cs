namespace MyStockApp.SubItems
{
    partial class GalmatgilForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalmatgilForm));
            this.Mtlback = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MtnSearch = new MetroFramework.Controls.MetroButton();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.kosNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Mtlback
            // 
            this.Mtlback.Location = new System.Drawing.Point(1187, 657);
            this.Mtlback.Name = "Mtlback";
            this.Mtlback.PaintTileCount = false;
            this.Mtlback.Size = new System.Drawing.Size(70, 40);
            this.Mtlback.TabIndex = 1;
            this.Mtlback.TileImage = global::MyStockApp.Properties.Resources.back2;
            this.Mtlback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Mtlback.UseTileImage = true;
            this.Mtlback.Click += new System.EventHandler(this.Mtlback_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1234, 588);
            this.metroTabControl1.TabIndex = 2;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.splitContainer1);
            this.metroTabPage1.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "갈맷길코스정보";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MtnSearch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DgvSearchItems);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1226, 548);
            this.splitContainer1.SplitterDistance = 274;
            this.splitContainer1.TabIndex = 2;
            // 
            // MtnSearch
            // 
            this.MtnSearch.Location = new System.Drawing.Point(1111, 3);
            this.MtnSearch.Name = "MtnSearch";
            this.MtnSearch.Size = new System.Drawing.Size(112, 44);
            this.MtnSearch.TabIndex = 0;
            this.MtnSearch.Text = "조회";
            this.MtnSearch.Click += new System.EventHandler(this.MtnSearch_Click);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kosNm,
            this.kosType,
            this.kosTxt,
            this.img,
            this.txt1,
            this.title,
            this.txt2});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.ReadOnly = true;
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(1226, 270);
            this.DgvSearchItems.TabIndex = 0;
            this.DgvSearchItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSearchItems_CellDoubleClick);
            // 
            // kosNm
            // 
            this.kosNm.HeaderText = "코스명";
            this.kosNm.Name = "kosNm";
            this.kosNm.ReadOnly = true;
            this.kosNm.Width = 150;
            // 
            // kosType
            // 
            this.kosType.HeaderText = "코스타입";
            this.kosType.Name = "kosType";
            this.kosType.ReadOnly = true;
            this.kosType.Width = 150;
            // 
            // kosTxt
            // 
            this.kosTxt.HeaderText = "코스구간";
            this.kosTxt.Name = "kosTxt";
            this.kosTxt.ReadOnly = true;
            this.kosTxt.Width = 150;
            // 
            // img
            // 
            this.img.HeaderText = "이미지";
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Width = 150;
            // 
            // txt1
            // 
            this.txt1.HeaderText = "코스정";
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Width = 150;
            // 
            // title
            // 
            this.title.HeaderText = "코스구간이름";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // txt2
            // 
            this.txt2.HeaderText = "코스부가정보";
            this.txt2.Name = "txt2";
            this.txt2.ReadOnly = true;
            // 
            // GalmatgilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Mtlback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GalmatgilForm";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "주식정보검색";
            this.Load += new System.EventHandler(this.SearchItemForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSearchItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile Mtlback;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroButton MtnSearch;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosType;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt2;
    }
}