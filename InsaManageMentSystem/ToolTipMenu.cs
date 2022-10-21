using System;
using System.Collections.Generic;

namespace InsaManageMentSystem
{
    public class ToolTipMenu
    {
        private string id;
        private string name;
        private List<ToolTipMenu> children;
        public string Id { get => this.id; set => this.id = value; }
        public string Name { get => this.name; set => this.name = value; }
        public List<ToolTipMenu> Children { get => this.children; set => this.children = value; }
    }

    public class ToolTipMenuRepository
    {
        public List<ToolTipMenu> CodeMenu { get; } = new List<ToolTipMenu>();
        public List<ToolTipMenu> TaskMenu { get; } = new List<ToolTipMenu>();
        public void InsertMenu(List<ToolTipMenu> targetMenu, string id, string name) 
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException($"'{nameof(id)}'은(는) Null이거나 비워 둘 수 없습니다.", nameof(id));
            }
            targetMenu.Add(new ToolTipMenu() { Id = id, Name = name });
        }

        public void InitializeMenus()
        {

            this.InsertMenu(this.CodeMenu,"Task001", "그룹코드 관리");
            this.InsertMenu(this.CodeMenu,"Task002", "일반코드 관리");
            this.InsertMenu(this.CodeMenu,"Task003", "인사코드 관리");
            this.InsertMenu(this.CodeMenu,"Task004", "부서코드 관리");
            this.InsertMenu(this.CodeMenu,"Task005", "직급코드 관리");
            this.InsertMenu(this.CodeMenu,"Task006", "직책코드 관리");

            this.InsertMenu(this.TaskMenu, "Task007", "인사기본사항");
            this.InsertMenu(this.TaskMenu, "Task008", "가족사항");
            this.InsertMenu(this.TaskMenu, "Task009", "학력사항");
            this.InsertMenu(this.TaskMenu, "Task010", "상벌사항");
            this.InsertMenu(this.TaskMenu, "Task011", "경력사항");
            this.InsertMenu(this.TaskMenu, "Task012", "자격면허");
            this.InsertMenu(this.TaskMenu, "Task013", "외국어");

            this.InsertMenu(this.TaskMenu, "Task014", "인사기본사항(종합)");
            this.InsertMenu(this.TaskMenu, "Task015", "인사발령대장");
            this.InsertMenu(this.TaskMenu, "Task016", "인사발령");
            this.InsertMenu(this.TaskMenu, "Task017", "인사발령(종합)");


            this.InsertMenu(this.TaskMenu, "Task018", "재직증명서");

            this.InsertMenu(this.TaskMenu, "Task021", "부서별 인원(현재)");


        }
    }
}
