using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public partial class UnitCodeModel
    {
        private string groupCode;
        private string unitCode;
        private string sequence;
        private string codeNames;
        private string codeName;
        private string addInfo;
        private string upper;
        private string use;
        private string sdate;
        private string edate;
        [DisplayName("그룹코드")] public string GroupCode { get => this.groupCode; set => this.groupCode = value; }
        [DisplayName("코드")] public string UnitCode { get => this.unitCode; set => this.unitCode = value; }
        [DisplayName("코드 Seq")] public string Sequence { get => this.sequence; set => this.sequence = value; }
        [DisplayName("코드명(축약)")] public string CodeNames { get => this.codeNames; set => this.codeNames = value; }
        [DisplayName("코드명(원형)")] public string CodeName { get => this.codeName; set => this.codeName = value; }
        [DisplayName("추가정보")] public string AddInfo { get => this.addInfo; set => this.addInfo = value; }
        [DisplayName("상위분류")] public string Upper { get => this.upper; set => this.upper = value; }
        [DisplayName("사용여부")] public string Use { get => this.use; set => this.use = value; }
        [DisplayName("생성일자")] public string Sdate { get => this.sdate; set => this.sdate = value; }
        [DisplayName("폐기일자")] public string Edate { get => this.edate; set => this.edate = value; }
    }
}
