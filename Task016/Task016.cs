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

namespace Task016
{
    public partial class Task016: UserControl
    {
        public Task016()
        {
            InitializeComponent();

            this.customDataGridView1.DataSource = new BindingList<PersonalAppoitementResiterModel>();
            this.customDataGridView2.DataSource = new BindingList<PersonlAppointmentModel>();
        }
    }
}
