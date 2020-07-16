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
using MetroFramework.Forms;

namespace MountainSearchApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitControls();
        }

        private void InitControls()
        {
            Dictionary<string, string> area = new Dictionary<string, string>();
            area.Add("선택", "");
            area.Add("서울특별시", "01");
            area.Add("부산광역시", "02");
            area.Add("대구광역시", "03");
            area.Add("인천광역시", "04");
            area.Add("광주광역시", "05");
            area.Add("대전광역시", "06");
            area.Add("울산광역시", "07");
            area.Add("경기도", "08");
            area.Add("강원도", "09");
            area.Add("충청북도", "10");
            area.Add("충청남도", "11");
            area.Add("전라북도", "12");
            area.Add("전라남도", "13");
            area.Add("경상북도", "14");
            area.Add("경상남도", "15");
            area.Add("제주도", "16");

            Dictionary<string, string> season = new Dictionary<string, string>();
            season.Add("선택", "");
            season.Add("봄", "01");
            season.Add("여름", "02");
            season.Add("가을", "03");
            season.Add("겨울", "04");

            CboArea.DataSource = new BindingSource(area, null);
            CboArea.DisplayMember = "Key";
            CboArea.ValueMember = "Value";

            CboSeason.DataSource = new BindingSource(season, null);
            CboSeason.DisplayMember = "Key";
            CboSeason.ValueMember = "Value";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();
            int totalCount = 1592;
            int num = 1;
            GridMoun.Rows.Clear();

            for (int pageNo = 1; pageNo < 10; pageNo++)
            {


                //Get 방식 URL 문자열 생성.
                str.Append("http://apis.data.go.kr/openapi/service/trailInfoService/getforeststoryservice"); //OpenAPI 기본 URL
                str.Append("?serviceKey=2397AZ16W0CRNwX58btT5QMtQ9gDRjo8TvCgF0Uj7QaSolpegysBotc5pVZg7HKyDBSK%2B%2BcabU%2FiMz5HfJmXVg%3D%3D");//인증키
                str.Append("&mntnNm=" + TxtMounName.Text); // 산이름
                str.Append("&mntnInfoAraCd=" + CboArea.SelectedValue); // 지역
                str.Append("&mntnInfoSsnCd=" + CboSeason.SelectedValue); // 계절
                str.Append("&pageNo=" + pageNo); // 페이지 수

                string xml = wc.DownloadString(str.ToString());
                doc.LoadXml(xml);

                XmlElement root = doc.DocumentElement;
                XmlNodeList items = doc.GetElementsByTagName("item");


                try
                {
                    foreach (XmlNode item in items)
                    {
                        GridMoun.Rows.Add(
                            num++,
                            item["mntnnm"].InnerText, //산 이름
                            item["mntninfopoflc"].InnerText, //지역wlfk
                            item["mntninfohght"].InnerText //높이
                            );
                    }

                }
                catch (NullReferenceException ex)
                {

                    MessageBox.Show($"에러 발생 : {ex.Message} ", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    str.Clear();
                }
            }


            GridMoun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
