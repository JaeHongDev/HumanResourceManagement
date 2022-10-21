using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicEducationModel
    {
        private string employNo;
        private string division;
        private string enterDate;
        private string graduatedDate;
        private string schoolName;
        private string shcoolDept;
        private string degree;
        private string grade;
        private string graduated;
        private string lasted;

        [DisplayName("사원번호")]
        public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("학력구분")]
        public string Division { get => this.division; set => this.division = value; }
        [DisplayName("입학일자")]
        public string EnterDate { get => this.enterDate; set => this.enterDate = value; }
        [DisplayName("졸업일자")]
        public string GraduatedDate { get => this.graduatedDate; set => this.graduatedDate = value; }
        [DisplayName("학교명")]
        public string SchoolName { get => this.schoolName; set => this.schoolName = value; }
        [DisplayName("학과(전공)")]
        public string ShcoolDept { get => this.shcoolDept; set => this.shcoolDept = value; }
        [DisplayName("학위")]
        public string Degree { get => this.degree; set => this.degree = value; }
        [DisplayName("성적")]
        public string Grade { get => this.grade; set => this.grade = value; }
        [DisplayName("졸업구분")]
        public string Graduated { get => this.graduated; set => this.graduated = value; }
        [DisplayName("최종여부")]
        public string Lasted { get => this.lasted; set => this.lasted = value; }
    }
}
