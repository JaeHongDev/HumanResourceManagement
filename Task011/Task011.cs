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

namespace Task011
{
    public partial class Task011: UserControl
    {
        public Task011()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<InsaBasicShortendModel>();
            this.customDataGridView2.DataSource = new BindingList<InsaBasicCarrerModel>();
        }
    }
}
