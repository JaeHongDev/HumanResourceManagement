using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicLanguageModel
    {

        private string empolyNo;
        private string name;
        private string score;
        private string acquisitionDate;
        private string organ;

        [DisplayName("사원번호")] public string EmpolyNo { get => this.empolyNo; set => this.empolyNo = value; }
        [DisplayName("자격증명")] public string Name { get => this.name; set => this.name = value; }
        [DisplayName("급수")] public string Score { get => this.score; set => this.score = value; }
        [DisplayName("취득일")] public string AcquisitionDate { get => this.acquisitionDate; set => this.acquisitionDate = value; }
        [DisplayName("발급기관")] public string Organ { get => this.organ; set => this.organ = value; }
    }
}
