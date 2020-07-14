using System;
using System.Data;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp.SubItems
{
    public partial class DivMngForm : MetroForm
    {
        readonly string strTblName = "divTbl";
        public DivMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            using (MySqlConnection con = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division,Names FROM {strTblName}";
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdDivTbl.DataSource = ds;
                GrdDivTbl.DataMember = strTblName;
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {

        }

        
    }
}
