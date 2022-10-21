using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsaManageMentSystem
{
    public class SampleMenus
    {
        public void main()
        {
            _ = new ToolMenu()
            {
                id = "0001",
                name = "0002",
                children = new List<ToolMenu>()
                {
                    new ToolMenu()
                    {
                        id="Task001",
                        name ="Task002",
                    },
                     new ToolMenu()
                    {
                        id="Task002",
                        name ="Task003",
                    }
                }
            };
        }
    }
    public class ToolMenu
    {
        public string id;
        public string name;
        public List<ToolMenu> children;
    }

}
