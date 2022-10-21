using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonTaskModel.Model;

namespace Task005
{
    public partial class Task005: UserControl
    {
        public Task005()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<UnitCodeModel>();
        }
    }
}
