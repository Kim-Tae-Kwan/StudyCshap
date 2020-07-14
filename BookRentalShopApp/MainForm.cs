﻿using System;
using System.Windows.Forms;
using BookRentalShopApp.SubItems;
using MetroFramework;
using MetroFramework.Forms;

namespace BookRentalShopApp
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MetroMessageBox.Show(this, "종류하시겠습니까?", "종료", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result ==DialogResult.Yes)//프로그램 종료
            {
                e.Cancel = false;
                Environment.Exit(0);
            }
            else // 프로그램 종료 안함
            {
                e.Cancel = true;
            }
        }

        private void MnuItemCodeMng_Click(object sender, EventArgs e)
        {
            DivMngForm form = new DivMngForm();
            form.MdiParent = this;
            form.Text = "구분코드 관리";
            form.Dock = DockStyle.Fill;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
        }

        private void MnuItemExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}