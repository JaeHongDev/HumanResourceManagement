using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTaskModules.Types;

namespace CommonTaskModules.Component
{
    public class CustomDataGridViewHeader
    {
        private bool visible = true;
        private string columnName;
        private string headerText;
        private string defaultValue;
        private Type type;
        public string ColumnName { get => columnName; set => columnName = value; }
        public string HeaderText { get => headerText; set => headerText = value; }
        public Type Type { get => type; set => type = value; }
        public bool Visible { get => visible; set => visible = value; }
        public string DefaultValue { get => defaultValue; set => defaultValue = value; }
    }
    public class CustomDataGridView : DataGridView
    {
        public CustomDataGridView()
        {
            this.InitializeComponent();
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.BackgroundColor = System.Drawing.Color.White;
            this.BorderStyle = BorderStyle.Fixed3D;
            this.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dock = DockStyle.Fill;
            this.EditMode = DataGridViewEditMode.EditProgrammatically;
            this.GridColor = System.Drawing.Color.FromArgb(241, 241, 240);
            this.Margin = new Padding(10);
            this.RowTemplate.Height = 23;
            this.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.DataBindingComplete += (o, _) =>
            {
                for (int i = 0; i < this.Columns.Count; i++)
                {
                    this.Columns[i].MinimumWidth = 150;
                }
            };
            
        }
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomDataGridView
            // 
            this.RowTemplate.Height = 23;
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        public void InitializeDataGridViewHeader(DataTable dataTable,List<CustomDataGridViewHeader> datagridViewHeader)
        {
            datagridViewHeader.ForEach(header =>
            {
                dataTable.Columns.Add(new DataColumn
                {
                    DataType = header.Type,
                    ColumnName = header.ColumnName,
                    Caption = header.HeaderText,
                    ColumnMapping = header.Visible ?  MappingType.Element: MappingType.Hidden,
                    DefaultValue = header.DefaultValue
                }); 
            });
            foreach (DataGridViewColumn col in this.Columns)
            {
                col.HeaderText = dataTable.Columns[col.Name].Caption;
            }
        }
    }
}
