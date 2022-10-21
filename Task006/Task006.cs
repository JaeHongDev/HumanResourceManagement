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

namespace Task006
{
    public partial class Task006: UserControl
    {
        public Task006()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<UnitCodeModel>();
        }
    }
}
