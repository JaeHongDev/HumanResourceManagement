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
using System.Runtime.InteropServices;

namespace Task007
{
    public partial class Task007: UserControl
    {
        public Task007()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<InsaBasicModel>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
