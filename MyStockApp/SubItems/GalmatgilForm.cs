using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace MyStockApp.SubItems
{
    public partial class GalmatgilForm : MetroForm//Form
    {
        public GalmatgilForm()
        {
            InitializeComponent();
        }

        private void SearchItemForm_Load(object sender, EventArgs e)
        {
            DgvSearchItems.Font = new Font(@"NanumGothic",15, FontStyle.Regular);
            splitContainer1.SplitterDistance = 50;
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mtlback_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            MainForm mainForm = new MainForm();
            mainForm.Location = this.Location;
            mainForm.ShowDialog();

            this.Close();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };

            StringBuilder str = new StringBuilder();
            str.Append("http://apis.data.go.kr/6260000/BusanGalmaetGilService/getGalmaetGilInfo");
            str.Append("?ServiceKey=2397AZ16W0CRNwX58btT5QMtQ9gDRjo8TvCgF0Uj7QaSolpegysBotc5pVZg7HKyDBSK%2B%2BcabU%2FiMz5HfJmXVg%3D%3D");
            str.Append("&pageNo=1");
            str.Append("&numOfRows=10");
            str.Append("&resultType=json");

            //json 사용
            string json = wc.DownloadString(str.ToString());
            JObject obj = JObject.Parse(json);
            JArray items = JArray.Parse(obj.SelectToken("getGalmaetGilInfo.item").ToString());
            DgvSearchItems.Rows.Clear();
            foreach (var item in items)
            {
                // kosNm, kosType,kosTxt,img,txt1,title,txt2
                DgvSearchItems.Rows.Add(
                    $"{item.SelectToken("kosNm")}",
                    $"{item.SelectToken("kosType")}",
                    $"{item.SelectToken("kosTxt")}",
                    $"{item.SelectToken("img")}",
                    $"{item.SelectToken("txt1")}",
                    $"{item.SelectToken("title")}",
                    $"{item.SelectToken("txt2")}"
                    );
            }


            DgvSearchItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                MtnSearch_Click(sender,new EventArgs());
            }
        }

        private void DgvSearchItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var selvalue = DgvSearchItems.Rows[e.RowIndex].Cells[3].Value.ToString(); //어딜 누르든 Cells[3]의 내용 출력.
            //MessageBox.Show(selvalue);
            DownloadForm form = new DownloadForm(); //DownloadForm 생성
            form.ParentUrl = selvalue;
            form.ShowDialog();//Form 실행

        }
    }
}
