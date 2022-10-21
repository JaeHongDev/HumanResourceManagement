using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicAwardModel
    {
        private string employNo;
        private string awardDate;
        private string awardNo;
        private string awardKind;
        private string awardOrgan;
        private string awardContent;
        private string awardInout;
        private string awardPosition;
        private string awardDept;

        [DisplayName("사원번호")]
        public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("수여일자")]
        public string AwardDate { get => this.awardDate; set => this.awardDate = value; }
        [DisplayName("수여번호")]
        public string AwardNo { get => this.awardNo; set => this.awardNo = value; }
        [DisplayName("수상종별")]
        public string AwardKind { get => this.awardKind; set => this.awardKind = value; }
        [DisplayName("수여자(시행처)")]
        public string AwardOrgan { get => this.awardOrgan; set => this.awardOrgan = value; }
        [DisplayName("수상내용")]
        public string AwardContent { get => this.awardContent; set => this.awardContent = value; }
        [DisplayName("내외구분")]
        public string AwardInout { get => this.awardInout; set => this.awardInout = value; }
        [DisplayName("직급(당시)")]
        public string AwardPosition { get => this.awardPosition; set => this.awardPosition = value; }
        [DisplayName("소속(당시)")]
        public string AwardDept { get => this.awardDept; set => this.awardDept = value; }
    }
}
