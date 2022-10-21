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

namespace Task009
{
    public partial class Task009: UserControl
    {
        public Task009()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<InsaBasicShortendModel>();
            this.customDataGridView2.DataSource = new BindingList<InsaBasicEducationModel>();
        }
    }
}
