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
    public partial class Main : Form
    {
        private readonly ToolTipMenuRepository toolTipMenuRepository = null;
        private readonly DllProvider dllProvider = null;
        private readonly List<CombinePresentTask> displayedScreens = null;

        public Main(ToolTipMenuRepository toolTipMenuRepository, DllProvider dllProvider)
        {
            this.InitializeComponent();
            this.dllProvider = dllProvider;
            // style
            this.InitializeStyles();
            // menu
            this.displayedScreens = new List<CombinePresentTask>();
            this.toolTipMenuRepository = toolTipMenuRepository;

            this.InitializeMenus();
        }
        private void InitializeMenus()
        {
            this.SetUpToolTipMenu(this.codeMenuStrip, this.toolTipMenuRepository.CodeMenu);
            this.SetUpToolTipMenu(this.taskMenuStrip, this.toolTipMenuRepository.TaskMenu);
        }

        private void InitializeStyles()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.BackColor = Color.FromArgb(243, 243, 243);
            menuStrip1.ForeColor = Color.FromArgb(123, 123, 123);

            sideMenu.BackColor = Color.FromArgb(44, 44, 44);
            sideMenu.ForeColor = Color.FromArgb(123, 123, 123);

            bottomPannel.BackColor = Color.FromArgb(0, 122, 204);
            bottomPannel.ForeColor = Color.FromArgb(235, 245, 251);

            pageViewr.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void SetUpToolTipMenu(ToolStripMenuItem targetToolStripMenuItem, List<ToolTipMenu> menus)
        {
            menus.ForEach(
                action: menu => targetToolStripMenuItem.DropDownItems.Add(this.InitializeToolStripMenuItem(menu))
            );
        }
        private ToolStripMenuItem InitializeToolStripMenuItem(ToolTipMenu menu)
        {
            ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem()
            {
                Tag = menu.Id,
                Text = menu.Name
            };
            toolStripMenuItem.Click += new System.EventHandler(this.ToolTipClickEvent);
            return toolStripMenuItem;
        }

        #region 이벤트 관리
        // ToolTip 클릭 이벤트
        private void ToolTipClickEvent(object sender, EventArgs e)
        {
            ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)sender;

            CombinePresentTask combinePresent = this.DisplayedCombinePresentTask(toolStripMenuItem);
            if (!(combinePresent is null))
            {
                combinePresent.Focus();
                return;
            }

            UserControl selectedUserControl =
                dllProvider.GetDllUserControls(toolStripMenuItem.Tag.ToString());
            
            if (selectedUserControl is null)
            {
                MessageBox.Show("해당 메뉴를 제공할 수 없습니다");
                return; 
            }
            
            CombinePresentTask combinePresentTask = new CombinePresentTask(selectedUserControl)
            {
                StartPosition = FormStartPosition.CenterScreen,
                Text = toolStripMenuItem.Text
            };
            combinePresentTask.Size = new Size(1280, 800);
            combinePresentTask.Show();

            combinePresentTask.FormClosed += new FormClosedEventHandler(FormClosed);
            void FormClosed(object sender1, FormClosedEventArgs e1)
            {
                this.displayedScreens.Remove(combinePresentTask);
            }
            this.displayedScreens.Add(combinePresentTask);
        }

        private CombinePresentTask DisplayedCombinePresentTask(ToolStripMenuItem toolStripMenuItem)
        {
            return this.displayedScreens.Find(screen => screen.DisplayedUserControl.Name.Equals(toolStripMenuItem.Tag));
        }
        #endregion
    }
}
