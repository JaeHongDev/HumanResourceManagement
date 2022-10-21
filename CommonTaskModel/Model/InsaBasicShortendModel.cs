using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicShortendModel
    {
        private string employNo;
        private string name;
        private string fix;
        private string contract;
        private string deptName;
        private string workState;
        private string states;
        private string postion;
        private string duration;

        [DisplayName("사번")] public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("성명")] public string Name { get => this.name; set => this.name = value; }
        [DisplayName("성별")] public string Fix { get => this.fix; set => this.fix = value; }
        [DisplayName("계약구분")] public string Contract { get => this.contract; set => this.contract = value; }
        [DisplayName("부서명")] public string DeptName { get => this.deptName; set => this.deptName = value; }
        [DisplayName("재직상태")] public string WorkState { get => this.workState; set => this.workState = value; }
        [DisplayName("신분구분")] public string States { get => this.states; set => this.states = value; }
        [DisplayName("직급")] public string Postion { get => this.postion; set => this.postion = value; }
        [DisplayName("직책")] public string Duration { get => this.duration; set => this.duration = value; }
    }
}
