using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTaskModules.Component;
using CommonTaskModules.Types;
using CommonTaskModules.Utils;
using Oracle.ManagedDataAccess.Client;

namespace Task001
{
    public partial class Task001 : UserControl, IPresentUc
    {
        private DataTable dataTable = new DataTable();
        public Task001()
        {
            InitializeComponent();
            #region DataGridView Initialize Event And bidning dataTable
            this.customDataGridView1.DataSource = this.dataTable;
            this.customDataGridView1.CellDoubleClick += new DataGridViewCellEventHandler(this.CustomDataGridView1CellDoubleClickEvent);
            this.Task001InitializeHeader();
            #endregion
            #region Textbox Binding Event
            this.cdg_grpcd.TextChanged += new EventHandler(this.ChangeText);
            this.cdg_grpnm.TextChanged += new EventHandler(this.ChangeText);
            this.cdg_digit.TextChanged += new EventHandler(this.ChangeText);
            this.cdg_length.TextChanged += new EventHandler(this.ChangeText);
            this.cdg_use.TextChanged += new EventHandler(this.ChangeText);
            this.cdg_kind.TextChanged += new EventHandler(this.ChangeText);
            /// textBox Foucs Event
            this.cdg_grpcd.GotFocus += new EventHandler(this.FocusText);
            this.cdg_grpnm.GotFocus += new EventHandler(this.FocusText);
            this.cdg_digit.GotFocus += new EventHandler(this.FocusText);
            this.cdg_length.GotFocus += new EventHandler(this.FocusText);
            this.cdg_use.GotFocus += new EventHandler(this.FocusText);
            this.cdg_kind.GotFocus += new EventHandler(this.FocusText);

            #endregion
        }
        /// <summary>
        /// Task001 customDatagridview Header Initialize
        /// </summary>
        public void Task001InitializeHeader()
        {
            var hedaers = new List<CommonTaskModules.Component.CustomDataGridViewHeader>
            {
                new CustomDataGridViewHeader
                {
                    ColumnName ="division",
                    HeaderText = "division",
                    Type = typeof(string),
                    DefaultValue = DivisionEnum.TYPE_ADD.ToString()
                },// division groupCode state
                new CustomDataGridViewHeader
                {
                    ColumnName = "cdg_grpcd_cp",
                    HeaderText ="*",
                    Type = typeof(string),
                    //Visible = false,
                },// copy cdg_grpcd
                new CustomDataGridViewHeader{
                    HeaderText = "그룹코드",
                    ColumnName = "cdg_grpcd",
                    Type = typeof(string)
                },// cdg_grpcd
                new CustomDataGridViewHeader{
                    HeaderText = "그룹코드명",
                    ColumnName = "cdg_grpnm",
                    Type = typeof(string)
                },// cdg_grpnm
                new CustomDataGridViewHeader{
                    HeaderText = "단위코드 자리수",
                    ColumnName = "cdg_digit",
                    Type = typeof(string)
                },
                new CustomDataGridViewHeader{
                    HeaderText = "단위코드명(원형) 길이",
                    ColumnName = "cdg_length",
                    Type = typeof(string)
                },
                new CustomDataGridViewHeader{
                    HeaderText = "사용여부",
                    ColumnName = "cdg_use",
                    Type = typeof(string)
                },
                new CustomDataGridViewHeader{
                    HeaderText = "분류",
                    ColumnName = "cdg_kind",
                    Type = typeof(string)
                }
            };
            this.customDataGridView1.InitializeDataGridViewHeader(dataTable, hedaers);
        }
        #region Button Event
        /// <summary>
        /// Add Buttin Action
        /// </summary>
        public void AddButton()
        {
            this.dataTable.Rows.Add();
        }
        /// <summary>
        /// Delete button Action that method delete Datagridview row. when this delete row that 
        /// division Enum type is TypeAdd delete row
        /// if TypeUpdate Or TypeSelect Or TypeDelete is change division TypeDelete
        /// </summary>
        public void DeleteButton()
        {
            if (this.customDataGridView1.SelectedRows.Count <= 0) return;

            var row = this.customDataGridView1.SelectedRows[0];
            if (row.Cells["division"].Value.Equals(DivisionEnum.TYPE_ADD.ToString()))
            {
                this.customDataGridView1.Rows.Remove(row);
                return;
            }

            MessageBox.Show("Are you Remove this?"); //change MessageBox to YesOrMessageBox
            List<OracleParameter> parameters = new List<OracleParameter>()
            {
                new OracleParameter("cdg_grpcd", row.Cells["cdg_grpcd_cp"].Value.ToString()),
            };
            Connection.ExecuteNonQuery(SqlCommand.DELETE_GRPCD, parameters);

            this.customDataGridView1.Rows.Remove(row);

        }
        /// <summary>
        /// Save Button Actions
        /// </summary>
        public void SaveButton()
        {
            foreach (DataGridViewRow row in this.customDataGridView1.Rows)
            {
                var item = row.Cells;
                if (row.Cells["division"].Value.Equals(DivisionEnum.TYPE_ADD.ToString()))
                {
                    List<OracleParameter> parameters = new List<OracleParameter>()
                    {
                        new OracleParameter("cdg_grpcd", item["cdg_grpcd"].Value.ToString()),
                        new OracleParameter("cdg_grpnm", item["cdg_grpnm"].Value.ToString()),
                        new OracleParameter("cdg_digit", int.Parse(item["cdg_digit"].Value.ToString())),
                        new OracleParameter("cdg_length", int.Parse(item["cdg_length"].Value.ToString())),
                        new OracleParameter("cdg_use", item["cdg_use"].Value.ToString()),
                        new OracleParameter("cdg_kind", item["cdg_kind"].Value.ToString()),
                    };
                    Connection.ExecuteNonQuery(SqlCommand.INSERT_GRPCD, parameters);
                    item["division"].Value = DivisionEnum.TYPE_SELECT.ToString();
                    item["cdg_grpcd_cp"].Value = item["cdg_grpcd"].Value;
                    continue;
                } // Add Data
                if (row.Cells["division"].Value.Equals(DivisionEnum.TYPE_UPDATE.ToString()))
                {
                    List<OracleParameter> parameters = new List<OracleParameter>()
                    {
                        new OracleParameter("cdg_grpcd", item["cdg_grpcd"].Value.ToString()),
                        new OracleParameter("cdg_grpnm", item["cdg_grpnm"].Value.ToString()),
                        new OracleParameter("cdg_digit", int.Parse(item["cdg_digit"].Value.ToString())),
                        new OracleParameter("cdg_length", int.Parse(item["cdg_length"].Value.ToString())),
                        new OracleParameter("cdg_use", item["cdg_use"].Value.ToString()),
                        new OracleParameter("cdg_kind", item["cdg_kind"].Value.ToString()),
                        new OracleParameter("cdg_grpcd_cp", item["cdg_grpcd_cp"].Value.ToString())
                    };
                    Connection.ExecuteNonQuery(SqlCommand.UPDATE_GRPCD, parameters);
                    item["division"].Value = DivisionEnum.TYPE_SELECT.ToString();
                    item["cdg_grpcd_cp"].Value = item["cdg_grpcd"].Value;
                }

            }
        }
        /// <summary>
        /// Select Button Action
        /// </summary>
        public void FindButton()
        {
            /*if(!StringToByte.LessThanStringToByteSize(this.searchGroupCodeName.Text,0 ))
            {
                MessageBox.Show("영어 2글자,한글 1글자 이상부터 검색가능합니다.");
            }*/
            // setting parameter
            List<OracleParameter> parameters = new List<OracleParameter>()
            {
                //CDG_GRPNM CDG_USE
                new OracleParameter("CDG_GRPNM",$"%{this.searchGroupCodeName.Text}%"),
                new OracleParameter("CDG_USE",$"%{this.searchUseCase.Text}%")
            };
            // get Oracle Connection
            using (var connection = Connection.GetConnection())
            {
                connection.Open();
                OracleDataReader reader = Connection.SetQuery(connection, SqlCommand.SELECT_GRPCD_NAME_OR_USECASE, parameters);

                if (reader is null) MessageBox.Show("DID NOT FOUND RESULT");
                // data read 
                this.dataTable.Rows.Clear();
                while (reader.Read()) InsertRow(reader);
            }
        }
        private void InsertRow(OracleDataReader reader)
        {
            DataRow row = this.dataTable.NewRow();
            row["division"] = DivisionEnum.TYPE_SELECT.ToString();
            row["CDG_GRPCD_CP"] = reader["CDG_GRPCD"].ToString();
            row["CDG_GRPCD"] = reader["CDG_GRPCD"].ToString();
            row["CDG_GRPNM"] = reader["CDG_GRPNM"].ToString();
            row["CDG_DIGIT"] = reader["CDG_DIGIT"].ToString();
            row["CDG_LENGTH"] = reader["CDG_LENGTH"].ToString();
            row["CDG_USE"] = reader["CDG_USE"].ToString();
            row["CDG_KIND"] = reader["CDG_KIND"].ToString();
            this.dataTable.Rows.Add(row);
        }
        #endregion
        private void CustomDataGridView1CellDoubleClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (this.customDataGridView1.Rows[e.RowIndex] is null) return;
            var item = this.customDataGridView1.Rows[e.RowIndex].Cells;

            this.cdg_grpcd.Text = item["cdg_grpcd"].Value.ToString();
            this.cdg_grpnm.Text = item["cdg_grpnm"].Value.ToString();
            this.cdg_digit.Text = item["cdg_digit"].Value.ToString();
            this.cdg_length.Text = item["cdg_length"].Value.ToString();
            this.cdg_use.Text = item["cdg_use"].Value.ToString();
            this.cdg_kind.Text = item["cdg_kind"].Value.ToString();
        }
        /// <summary>
        /// this changeText is input TextBox ChangeEvent.
        /// when TextBox was Changed datagridview Column change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeText(object sender, EventArgs e)
        {
            var selectedRow = this.customDataGridView1.SelectedRows;
            if (selectedRow.Count <= 0) return;
            var nowControl = (Control)sender;
            selectedRow[0].Cells[nowControl.Name].Value = nowControl.Text;
        }
        /// <summary>
        /// this focusText is input focus Event. When TextBox was focused
        /// change datagridview DivisionEnum select To Update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FocusText(object sender, EventArgs e)
        {
            var selectedRow = this.customDataGridView1.SelectedRows;
            if (selectedRow.Count <= 0) return;
            if (selectedRow[0].Cells["division"].Value.Equals(DivisionEnum.TYPE_SELECT.ToString()))
            {
                selectedRow[0].Cells["division"].Value = DivisionEnum.TYPE_UPDATE.ToString();
            }
        }
    }
}
