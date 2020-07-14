namespace MyStockApp.SubItems
{
    partial class SearchItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchItemForm));
            this.Mtlback = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtSearchItem = new MetroFramework.Controls.MetroTextBox();
            this.MtnSearch = new MetroFramework.Controls.MetroButton();
            this.DgvSearchItems = new System.Windows.Forms.DataGridView();
            this.isin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.korSecnNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secnKacdNm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shotnLsin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
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
            this.metroTabPage1.Text = "주식기초정보수집";
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
            this.splitContainer1.Panel1.Controls.Add(this.TxtSearchItem);
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
            // TxtSearchItem
            // 
            this.TxtSearchItem.Location = new System.Drawing.Point(908, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(197, 44);
            this.TxtSearchItem.TabIndex = 1;
            this.TxtSearchItem.Click += new System.EventHandler(this.metroTextBox1_Click);
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // MtnSearch
            // 
            this.MtnSearch.Location = new System.Drawing.Point(1111, 3);
            this.MtnSearch.Name = "MtnSearch";
            this.MtnSearch.Size = new System.Drawing.Size(112, 44);
            this.MtnSearch.TabIndex = 0;
            this.MtnSearch.Text = "검색";
            this.MtnSearch.Click += new System.EventHandler(this.MtnSearch_Click);
            // 
            // DgvSearchItems
            // 
            this.DgvSearchItems.AllowUserToAddRows = false;
            this.DgvSearchItems.AllowUserToDeleteRows = false;
            this.DgvSearchItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSearchItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isin,
            this.issuDt,
            this.korSecnNm,
            this.secnKacdNm,
            this.shotnLsin});
            this.DgvSearchItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvSearchItems.Location = new System.Drawing.Point(0, 0);
            this.DgvSearchItems.Name = "DgvSearchItems";
            this.DgvSearchItems.ReadOnly = true;
            this.DgvSearchItems.RowTemplate.Height = 23;
            this.DgvSearchItems.Size = new System.Drawing.Size(1226, 270);
            this.DgvSearchItems.TabIndex = 0;
            // 
            // isin
            // 
            this.isin.HeaderText = "표준코드";
            this.isin.Name = "isin";
            this.isin.ReadOnly = true;
            this.isin.Width = 150;
            // 
            // issuDt
            // 
            this.issuDt.HeaderText = "주식 발행일자";
            this.issuDt.Name = "issuDt";
            this.issuDt.ReadOnly = true;
            this.issuDt.Width = 150;
            // 
            // korSecnNm
            // 
            this.korSecnNm.HeaderText = "한글 종목명";
            this.korSecnNm.Name = "korSecnNm";
            this.korSecnNm.ReadOnly = true;
            this.korSecnNm.Width = 150;
            // 
            // secnKacdNm
            // 
            this.secnKacdNm.HeaderText = "보통주/우선주";
            this.secnKacdNm.Name = "secnKacdNm";
            this.secnKacdNm.ReadOnly = true;
            this.secnKacdNm.Width = 150;
            // 
            // shotnLsin
            // 
            this.shotnLsin.HeaderText = "단축코드";
            this.shotnLsin.Name = "shotnLsin";
            this.shotnLsin.ReadOnly = true;
            this.shotnLsin.Width = 150;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Font = new System.Drawing.Font("나눔고딕코딩", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 36);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1226, 548);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "해당정보수집";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // SearchItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.Mtlback);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchItemForm";
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
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroTextBox TxtSearchItem;
        private MetroFramework.Controls.MetroButton MtnSearch;
        private System.Windows.Forms.DataGridView DgvSearchItems;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isin;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn korSecnNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn secnKacdNm;
        private System.Windows.Forms.DataGridViewTextBoxColumn shotnLsin;
    }
}