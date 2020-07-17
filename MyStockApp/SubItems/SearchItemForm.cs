using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MyStockApp.SubItems
{
    public partial class SearchItemForm : MetroForm//Form
    {
        public SearchItemForm()
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
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            //Get 방식 URL 문자열 생성.
            str.Append("http://api.seibro.or.kr/openapi/service/StockSvc/getStkIsinByNmN1"); //OpenAPI 기본 URL
            str.Append("?serviceKey=2397AZ16W0CRNwX58btT5QMtQ9gDRjo8TvCgF0Uj7QaSolpegysBotc5pVZg7HKyDBSK%2B%2BcabU%2FiMz5HfJmXVg%3D%3D");//인증키
            str.Append("&secnNm="+TxtSearchItem.Text); //종목명
            str.Append("&numOfRows=200"); //읽어올 데이터 수
            str.Append("&pageNo=1"); //페이지 수
            str.Append("&martTpcd=11"); //주식시장 종류 : 11은 유가증권시장

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            DgvSearchItems.Rows.Clear();
            try
            {
                foreach (XmlNode item in items)
                {
                    DgvSearchItems.Rows.Add(
                        item["isin"].InnerText, //표준코드
                        item["issuDt"].InnerText,//item["issuDt"] == null ? string.Empty : item["issuDt"].InnerText,//주식 발행일자
                        item["korSecnNm"].InnerText,//한글 종목명
                        item["secnKacdNm"].InnerText,//보통주/우선주
                        item["shotnIsin"].InnerText// 단축코드
                        );
                }

            }
            catch (NullReferenceException ex)
            {

                MessageBox.Show($"에러 발생 : {ex.Message} ", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
