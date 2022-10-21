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
    public partial class CustomButtonProvider : UserControl
    {
        private IPresentUc combinePresent = null;
        public CustomButtonProvider()
        {
            InitializeComponent();
        }

        internal void setPresetTask(Control combinePresentTask)
        {
            this.combinePresent = (IPresentUc)combinePresentTask;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if(combinePresent is null) return; 
            combinePresent?.AddButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (combinePresent is null) return;
            combinePresent?.SaveButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (combinePresent is null) return;
            combinePresent?.SaveButton();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (combinePresent is null) return;
            combinePresent?.FindButton();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (combinePresent is null) return;
            combinePresent?.AddButton();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (combinePresent is null) return;
            combinePresent?.DeleteButton();
         }
    }
}
