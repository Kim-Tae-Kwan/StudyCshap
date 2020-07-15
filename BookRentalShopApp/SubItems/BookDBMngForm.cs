﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;

namespace BookRentalShopApp.SubItems
{
    public partial class BookDBMngForm : MetroForm
    {
        readonly string strTblName = "booksTbl";

        BaseMode MyMode=BaseMode.NONE;
        public BookDBMngForm()
        {
            InitializeComponent();
        }

        private void DivMngForm_Load(object sender, EventArgs e)
        {
            InitControls();
            UpdateComboboxDivision();
            UpdateData();
        }

        private void UpdateComboboxDivision()
        {
            using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT Division, Names FROM divTbl ";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(strQuery, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                Dictionary<string, string> temps = new Dictionary<string, string>();
                temps.Add("선택", "");

                while (reader.Read())
                {
                    temps.Add(reader[1].ToString(), reader[0].ToString());
                }

                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Key";
                CboDivision.ValueMember = "Value";
                //CboDivision.SelectedIndex = -1;
                
            }
        }

        private void UpdateData()
        {
            using (MySqlConnection con = new MySqlConnection(Commons.CONNSTR))
            {
                string strQuery = $"SELECT b.Idx, " +
                                   "       b.Author, " +
                                   "       b.Division, " +
                                   "       d.Names AS DIvisionName, " +
                                   "       b.Names, " +
                                   "       b.ReleaseDate, " +
                                   "       b.ISBN, " +
                                   "       b.Price " +
                                   " FROM bookstbl AS b " +
                                   " INNER JOIN divtbl AS d " +
                                   " ON b.Division = d.Division";
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(strQuery, con);
                DataSet ds = new DataSet();
                adapter.Fill(ds, strTblName);

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = strTblName;
            }

            SetColumnHeaders();

        }

        private void SetColumnHeaders()
        {
            DataGridViewColumn column;

            column = GrdBooksTbl.Columns[0];
            column.Width = 100;
            column.HeaderText = "번호";

            column = GrdBooksTbl.Columns[1];
            column.Width = 120;
            column.HeaderText = "저자명";

            column = GrdBooksTbl.Columns[2];
            column.Visible = false;

            column = GrdBooksTbl.Columns[3];
            column.Width = 100;
            column.HeaderText = "장르";

            column = GrdBooksTbl.Columns[4];
            column.Width = 200;
            column.HeaderText = "이름";

            column = GrdBooksTbl.Columns[5];
            column.Width = 150;
            column.HeaderText = "출간일";

            column = GrdBooksTbl.Columns[6];
            column.Width = 150;
            column.HeaderText = "ISBN";

            column = GrdBooksTbl.Columns[7];
            column.Width = 100;
            column.HeaderText = "가격";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(MyMode != BaseMode.UPDATE)
            {
                MetroMessageBox.Show(this, "삭제할 데이터를 선택하세요!!", "알림");
                return;
            }
            MyMode = BaseMode.DELETE;
            SaveData();
            InitControls();
        }

        private void InitControls()
        {
            TxtNum.Text = TxtAuthor.Text = String.Empty;
            TxtNum.Focus();

            MyMode = BaseMode.NONE;

            //콤보박스 데이터바인딩
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("선택", "00");
            //dic.Add("서울특별시", "11");
            //dic.Add("부산광역시", "21");
            //dic.Add("대구광역시", "22");
            //dic.Add("인천광역시", "23");
            //dic.Add("광주광역시", "24");
            //dic.Add("대전광역시", "25");

            //CboDivision.DataSource = new BindingSource(dic, null);
            //CboDivision.DisplayMember = "Key";
            //CboDivision.ValueMember = "Value";

        }
        #region 삭제 메소드 주석
        /*
        private void DeleteProcess()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR)) //using 사용시 conn.close() 안씀
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "DELETE FROM divtbl " +
                                      "  WHERE Divison = @Division";
                    MySqlParameter paramDivison = new MySqlParameter("@Division", MySqlDbType.VarChar);
                    paramDivison.Value = TxtDivison.Text;
                    cmd.Parameters.Add(paramDivison);

                    cmd.ExecuteNonQuery();
                }
                    
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtDivison.Focus();
                UpdateData();
            }

        }
        */
        #endregion

        private void BtnNew_Click(object sender, EventArgs e)
        {
            TxtNum.Text = TxtAuthor.Text = string.Empty;
            TxtNum.ReadOnly = false;

            TxtNum.Focus();
            MyMode = BaseMode.INSERT; // 신규입력 모드
        }

        /// <summary>
        /// DB 업데이트 및 입력
        /// </summary>
        private void SaveData()
        {
            if (string.IsNullOrEmpty(TxtNum.Text) || string.IsNullOrEmpty(TxtAuthor.Text))
            {
                MetroMessageBox.Show(this, "빈 값은 넣을 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(MyMode == BaseMode.NONE)
            {
                MetroMessageBox.Show(this, "신규등록 시 신규 버튼을 눌러주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(Commons.CONNSTR)) //using 사용시 conn.close() 안씀
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    if(MyMode == BaseMode.UPDATE)
                    {
                        cmd.CommandText = "UPDATE divtbl " +
                                          "  SET Names = @Names " +
                                          " WHERE Division = @Division"; //Update문 작성
                    }
                    else if(MyMode == BaseMode.INSERT)
                    {
                        cmd.CommandText = "INSERT INTO "+
                                          " divtbl (Division,Names) "+
                                          " VALUES(@Division, @Names); ";
                    }
                    else if(MyMode == BaseMode.DELETE)
                    {
                        cmd.CommandText = "DELETE FROM divtbl " +
                                      "  WHERE Division = @Division";
                    }

                    if(MyMode == BaseMode.INSERT || MyMode == BaseMode.UPDATE)
                    {
                        MySqlParameter paramNames = new MySqlParameter("@Names", MySqlDbType.VarChar, 45); // 파라미터 설정
                        paramNames.Value = TxtAuthor.Text;
                        cmd.Parameters.Add(paramNames); //@Names <=== paramNames.Value

                        MySqlParameter paramDivision = new MySqlParameter("@Division", MySqlDbType.VarChar, 4);
                        paramDivision.Value = TxtNum.Text;
                        cmd.Parameters.Add(paramDivision); //@Division <=== paramDivision.Value
                    }
                    else if(MyMode == BaseMode.DELETE)
                    {
                        MySqlParameter paramDivison = new MySqlParameter("@Division", MySqlDbType.VarChar);
                        paramDivison.Value = TxtNum.Text;
                        cmd.Parameters.Add(paramDivison);
                    }

                    var result = cmd.ExecuteNonQuery(); //쿼리문 실행.

                    if(MyMode == BaseMode.INSERT)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 신규입력되었습니다.", "신규입력");
                    }
                    else if(MyMode == BaseMode.UPDATE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 수정되었습니다.", "수정");
                    }
                    else if(MyMode == BaseMode.DELETE)
                    {
                        MetroMessageBox.Show(this, $"{result}건이 삭제되었습니다.", "삭제");
                    }
                }



            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"에러 발생 {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                TxtNum.Focus();
                UpdateData();
            }
        }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            InitControls();
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                //Grid 셀 중 Rows 데이터 들고옴
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];//선택한 행의 데이터 들고옴
                TxtNum.Text = data.Cells[0].Value.ToString();//행의 0번째 열 데이터
                TxtAuthor.Text = data.Cells[1].Value.ToString();//행의 1번째 열 데이터

                TxtNum.ReadOnly = true; //PK가 들어가는 텍스트는 수정 안함!!

                MyMode = BaseMode.UPDATE; // 수정 모드 변경
            }


        }

        private void CboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CboDivision.SelectedIndex > 0)
                MessageBox.Show(CboDivision.SelectedValue.ToString());
        }
    }
}
