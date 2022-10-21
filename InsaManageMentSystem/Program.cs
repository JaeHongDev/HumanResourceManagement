using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsaManageMentSystem
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ToolTipMenuRepository toolTipMenuRepository = new ToolTipMenuRepository();
            toolTipMenuRepository.InitializeMenus();

            DllProvider dllProvider = new DllProvider();
            Application.Run(new Main(toolTipMenuRepository, dllProvider));
            //Application.Run(new Form1());
        }
    }
}
