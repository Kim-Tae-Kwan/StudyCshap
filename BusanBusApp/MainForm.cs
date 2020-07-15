using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;


namespace BusanBusApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtBusStopName.Focus();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            //Get 방식 URL 문자열 생성.
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/busStop"); //OpenAPI 기본 URL
            str.Append("?ServiceKey=2397AZ16W0CRNwX58btT5QMtQ9gDRjo8TvCgF0Uj7QaSolpegysBotc5pVZg7HKyDBSK%2B%2BcabU%2FiMz5HfJmXVg%3D%3D");//인증키
            str.Append("&bstopnm=" + TxtBusStopName.Text);//정류소명

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            metroGrid1.Rows.Clear();
            foreach (XmlNode item in items)
            {
                  metroGrid1.Rows.Add(
                      item["bstopNm"].InnerText,
                      item["bstopId"].InnerText
                      );
            }

        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
                XmlDocument doc = new XmlDocument();

                StringBuilder str = new StringBuilder();
                //Grid 셀 중 Rows 데이터 들고옴
                DataGridViewRow data = metroGrid1.Rows[e.RowIndex];//선택한 행의 데이터 들고옴

            //Get 방식 URL 문자열 생성.
            
                str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/stopArr"); //OpenAPI 기본 URL
                str.Append("?ServiceKey=2397AZ16W0CRNwX58btT5QMtQ9gDRjo8TvCgF0Uj7QaSolpegysBotc5pVZg7HKyDBSK%2B%2BcabU%2FiMz5HfJmXVg%3D%3D");//인증키
                str.Append("&bstopid=" + data.Cells[1].Value.ToString());//정류소명

            
                string xml = wc.DownloadString(str.ToString());
                doc.LoadXml(xml);

                XmlElement root = doc.DocumentElement;
                XmlNodeList items = doc.GetElementsByTagName("item");

                GrdBusStopInfo.Rows.Clear();
                foreach (XmlNode item in items)
                {
                    GrdBusStopInfo.Rows.Add(
                        item["lineNo"].InnerText,
                        item["min1"] == null ? "도착 정보 없음": $"{item["min1"].InnerText}분"
                        );
                    GrdBusStopInfo.Rows.Add("", item["min2"] == null ? "도착 정보 없음" : $"{item["min2"].InnerText}분");
                }




            }
        }
    }
}
