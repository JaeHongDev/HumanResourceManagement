using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicFamilyModel
    {
        private string employNo;
        private string relation;
        private string name;
        private string birth;
        private string livingTogether;

        [DisplayName("사원번호")] public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("관계")] public string Relation { get => this.relation; set => this.relation = value; }
        [DisplayName("성명")] public string Name { get => this.name; set => this.name = value; }
        [DisplayName("생년월일")] public string Birth { get => this.birth; set => this.birth = value; }
        [DisplayName("동거여부")] public string LivingTogether { get => this.livingTogether; set => this.livingTogether = value; }
    }
}
