﻿using MetroFramework.Forms;
using MyStockApp.SubItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStockApp
{
    public partial class MainForm : MetroForm// Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Size.Width / 2, 
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2
                );
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void MtlSearchItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            SearchItemForm searchitem = new SearchItemForm();
            searchitem.Location = this.Location;
            searchitem.ShowDialog();

            this.Close();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            GalmatgilForm form = new GalmatgilForm();
            form.Location = this.Location;
            form.ShowDialog();
            
            this.Close();
        }
    }
}
