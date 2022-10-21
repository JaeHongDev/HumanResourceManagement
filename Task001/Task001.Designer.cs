namespace Task001
{
    partial class Task001
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cdg_kind = new System.Windows.Forms.TextBox();
            this.cdg_use = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.searchUseCase = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cdg_digit = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchGroupCodeName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cdg_grpnm = new System.Windows.Forms.TextBox();
            this.cdg_length = new System.Windows.Forms.NumericUpDown();
            this.cdg_grpcd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customDataGridView1 = new CommonTaskModules.Component.CustomDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_digit)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cdg_kind
            // 
            this.cdg_kind.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.cdg_kind.Location = new System.Drawing.Point(122, 146);
            this.cdg_kind.Name = "cdg_kind";
            this.cdg_kind.Size = new System.Drawing.Size(101, 21);
            this.cdg_kind.TabIndex = 0;
            this.cdg_kind.Tag = "KOR";
            // 
            // cdg_use
            // 
            this.cdg_use.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cdg_use.FormattingEnabled = true;
            this.cdg_use.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cdg_use.Location = new System.Drawing.Point(122, 124);
            this.cdg_use.Name = "cdg_use";
            this.cdg_use.Size = new System.Drawing.Size(43, 20);
            this.cdg_use.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "그룹코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "분류";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "그룹코드명";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "사용여부";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "단위코드길이(원형)";
            // 
            // searchUseCase
            // 
            this.searchUseCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchUseCase.FormattingEnabled = true;
            this.searchUseCase.Items.AddRange(new object[] {
            "Y",
            "N",
            ""});
            this.searchUseCase.Location = new System.Drawing.Point(296, 13);
            this.searchUseCase.Name = "searchUseCase";
            this.searchUseCase.Size = new System.Drawing.Size(53, 20);
            this.searchUseCase.TabIndex = 37;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 32;
            this.label15.Text = "사용여부";
            // 
            // cdg_digit
            // 
            this.cdg_digit.Location = new System.Drawing.Point(122, 79);
            this.cdg_digit.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cdg_digit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cdg_digit.Name = "cdg_digit";
            this.cdg_digit.Size = new System.Drawing.Size(40, 21);
            this.cdg_digit.TabIndex = 3;
            this.cdg_digit.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 370F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customDataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox2, 2);
            this.groupBox2.Controls.Add(this.searchUseCase);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.searchGroupCodeName);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(10, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // searchGroupCodeName
            // 
            this.searchGroupCodeName.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.searchGroupCodeName.Location = new System.Drawing.Point(72, 13);
            this.searchGroupCodeName.Name = "searchGroupCodeName";
            this.searchGroupCodeName.Size = new System.Drawing.Size(160, 21);
            this.searchGroupCodeName.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 34;
            this.label16.Text = "그룹코드명";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cdg_grpnm);
            this.groupBox1.Controls.Add(this.cdg_length);
            this.groupBox1.Controls.Add(this.cdg_grpcd);
            this.groupBox1.Controls.Add(this.cdg_digit);
            this.groupBox1.Controls.Add(this.cdg_kind);
            this.groupBox1.Controls.Add(this.cdg_use);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(430, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.groupBox1.Name = "groupBox1";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(360, 395);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // cdg_grpnm
            // 
            this.cdg_grpnm.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.cdg_grpnm.Location = new System.Drawing.Point(122, 55);
            this.cdg_grpnm.Name = "cdg_grpnm";
            this.cdg_grpnm.Size = new System.Drawing.Size(218, 21);
            this.cdg_grpnm.TabIndex = 0;
            this.cdg_grpnm.Tag = "KOR";
            // 
            // cdg_length
            // 
            this.cdg_length.Location = new System.Drawing.Point(122, 101);
            this.cdg_length.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.cdg_length.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cdg_length.Name = "cdg_length";
            this.cdg_length.Size = new System.Drawing.Size(40, 21);
            this.cdg_length.TabIndex = 3;
            this.cdg_length.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cdg_grpcd
            // 
            this.cdg_grpcd.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.cdg_grpcd.Location = new System.Drawing.Point(122, 32);
            this.cdg_grpcd.Name = "cdg_grpcd";
            this.cdg_grpcd.Size = new System.Drawing.Size(218, 21);
            this.cdg_grpcd.TabIndex = 0;
            this.cdg_grpcd.Tag = "ENG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "단위코드길이";
            // 
            // customDataGridView1
            // 
            this.customDataGridView1.AllowUserToAddRows = false;
            this.customDataGridView1.AllowUserToDeleteRows = false;
            this.customDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.customDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.customDataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.customDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.customDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.customDataGridView1.Location = new System.Drawing.Point(10, 55);
            this.customDataGridView1.Margin = new System.Windows.Forms.Padding(10);
            this.customDataGridView1.Name = "customDataGridView1";
            this.customDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel1.SetRowSpan(this.customDataGridView1, 2);
            this.customDataGridView1.RowTemplate.Height = 23;
            this.customDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customDataGridView1.Size = new System.Drawing.Size(410, 385);
            this.customDataGridView1.TabIndex = 6;
            // 
            // Task001
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Task001";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.cdg_digit)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cdg_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cdg_kind;
        private System.Windows.Forms.ComboBox cdg_use;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox searchUseCase;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown cdg_digit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox searchGroupCodeName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cdg_grpnm;
        private System.Windows.Forms.NumericUpDown cdg_length;
        private System.Windows.Forms.TextBox cdg_grpcd;
        private System.Windows.Forms.Label label3;
        private CommonTaskModules.Component.CustomDataGridView customDataGridView1;
    }
}
