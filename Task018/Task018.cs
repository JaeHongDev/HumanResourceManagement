using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task018
{
    public partial class Task018: UserControl
    {
        public Task018()
        {
            InitializeComponent();
            reportViewer1.RefreshReport();
        }
    }
}
