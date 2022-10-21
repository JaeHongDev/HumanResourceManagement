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

namespace Task014
{
    public partial class Task014: UserControl
    {
        public class InsaBasicCombineModel
        {
            public InsaBasicShortendModel insaBasicShortendModel;
            public InsaBasicFamilyModel insaBasicFamilyModel;
            public InsaBasicEducationModel insaBasicEducationModel;
            public InsaBasicCarrerModel InsaBasicCarrerModel;
            public InsaBasicAwardModel insaBasicAwardModel;
        }
        public Task014()
        {
            InitializeComponent();
            this.customDataGridView1.DataSource = new BindingList<InsaBasicShortendModel>();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
