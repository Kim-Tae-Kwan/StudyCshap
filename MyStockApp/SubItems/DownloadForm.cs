using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStockApp.SubItems
{
    public partial class DownloadForm : MetroForm
    {
        public string ParentUrl { get; set; }

        WebClient client = new WebClient();


        public DownloadForm()
        {
            InitializeComponent();
        }

        private void DownloadForm_Load(object sender, EventArgs e)
        {
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string FileName = ParentUrl.Substring(ParentUrl.IndexOf("=") + 1);
            pictureBox1.Load(Environment.CurrentDirectory + $@"\{FileName}");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate()
            {
                progressBar1.Value = e.ProgressPercentage;

                if(e.BytesReceived == e.TotalBytesToReceive) // 다운로드 완료 하면
                {
                    Client_DownloadFileCompleted(sender, null);
                }
            }
                ));
        }

        private void DownloadForm_Shown(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(StartDownload)); // 스레드 생성
            thread.Start(); // 스레드 시작
        }

        private void StartDownload()
        {
            Uri uri = new Uri(ParentUrl);
            string FileName = ParentUrl.Substring(ParentUrl.IndexOf("=") + 1); //마지막에 나오는 이미지파일명 들고 오기.
            client.DownloadFileAsync(uri, Environment.CurrentDirectory + $@"\{FileName}"); // @ : 유니코드??
        }
    }
}
