using CommonTaskModules.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaManageMentSystem
{
    public partial class CombinePresentTask : Form
    {
        public readonly UserControl DisplayedUserControl = null;
        public CombinePresentTask(UserControl userControl)
        {
            this.InitializeComponent();
            this.InitializeTaskPresent(userControl);
            this.DisplayedUserControl = userControl;
        }
        private void InitializeTaskPresent(UserControl userControl)
        {
            userControl.BackColor = Color.White;
            userControl.Dock = DockStyle.Fill;
            this.viewer.Controls.Add(userControl);
            customButtonProvider1.setPresetTask(userControl);
        }
    }
}
