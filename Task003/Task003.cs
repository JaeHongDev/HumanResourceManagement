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

namespace Task003
{
    public partial class Task003: UserControl
    {
        public Task003()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<UnitCodeModel>();
        }
    }
}
