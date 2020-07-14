using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MetroFramework.Forms;


namespace BusanBusApp
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient() { Encoding = Encoding.UTF8 };
            XmlDocument doc = new XmlDocument();

            StringBuilder str = new StringBuilder();

            //Get 방식 URL 문자열 생성.
            str.Append("http://61.43.246.153/openapi-data/service/busanBIMS2/busStop"); //OpenAPI 기본 URL
            str.Append("?serviceKey=MAks6OUeYB0tk4rqW1sV3wlv0LVY2YA3AtTi4PnciAqKhffDiZjU%2FJ3AQlEFqslb6W6S2BSsim97xFNxIzjfNA%3D%3D");//인증키
            str.Append("&bstopnm=" + TxtBusStopName.Text);//정류소명

            string xml = wc.DownloadString(str.ToString());
            doc.LoadXml(xml);

            XmlElement root = doc.DocumentElement;
            XmlNodeList items = doc.GetElementsByTagName("item");

            items["bstopid"]

        }
    }
}
