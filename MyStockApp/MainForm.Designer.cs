namespace MyStockApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MtlSearchItem = new MetroFramework.Controls.MetroTile();
            this.MtlAnalysis = new MetroFramework.Controls.MetroTile();
            this.MtlSimulator = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MtlSearchItem
            // 
            this.MtlSearchItem.Location = new System.Drawing.Point(20, 63);
            this.MtlSearchItem.Name = "MtlSearchItem";
            this.MtlSearchItem.PaintTileCount = false;
            this.MtlSearchItem.Size = new System.Drawing.Size(257, 150);
            this.MtlSearchItem.TabIndex = 0;
            this.MtlSearchItem.Text = "주식정보검색";
            this.MtlSearchItem.TileImage = global::MyStockApp.Properties.Resources.marketing2;
            this.MtlSearchItem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSearchItem.UseTileImage = true;
            this.MtlSearchItem.Click += new System.EventHandler(this.MtlSearchItem_Click);
            // 
            // MtlAnalysis
            // 
            this.MtlAnalysis.Location = new System.Drawing.Point(282, 63);
            this.MtlAnalysis.Name = "MtlAnalysis";
            this.MtlAnalysis.PaintTileCount = false;
            this.MtlAnalysis.Size = new System.Drawing.Size(128, 150);
            this.MtlAnalysis.Style = MetroFramework.MetroColorStyle.Orange;
            this.MtlAnalysis.TabIndex = 1;
            this.MtlAnalysis.Text = "주식정보분석";
            this.MtlAnalysis.TileImage = global::MyStockApp.Properties.Resources.analysis2;
            this.MtlAnalysis.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlAnalysis.UseTileImage = true;
            // 
            // MtlSimulator
            // 
            this.MtlSimulator.Location = new System.Drawing.Point(20, 219);
            this.MtlSimulator.Name = "MtlSimulator";
            this.MtlSimulator.PaintTileCount = false;
            this.MtlSimulator.Size = new System.Drawing.Size(390, 150);
            this.MtlSimulator.Style = MetroFramework.MetroColorStyle.Lime;
            this.MtlSimulator.TabIndex = 2;
            this.MtlSimulator.Text = "투자시뮬레이터";
            this.MtlSimulator.TileImage = global::MyStockApp.Properties.Resources.simulator2;
            this.MtlSimulator.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MtlSimulator.UseTileImage = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.MtlSimulator);
            this.Controls.Add(this.MtlAnalysis);
            this.Controls.Add(this.MtlSearchItem);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(17, 60, 17, 20);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "주식분석시스템";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile MtlSearchItem;
        private MetroFramework.Controls.MetroTile MtlAnalysis;
        private MetroFramework.Controls.MetroTile MtlSimulator;
    }
}

