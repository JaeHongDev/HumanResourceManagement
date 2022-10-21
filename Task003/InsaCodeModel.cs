using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task003
{
    public class InsaCodeModel
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
        public string GroupCode { get => this.groupCode; set => this.groupCode = value; }
        public string UnitCode { get => this.unitCode; set => this.unitCode = value; }
        public string Sequence { get => this.sequence; set => this.sequence = value; }
        public string CodeNames { get => this.codeNames; set => this.codeNames = value; }
        public string CodeName { get => this.codeName; set => this.codeName = value; }
        public string AddInfo { get => this.addInfo; set => this.addInfo = value; }
        public string Upper { get => this.upper; set => this.upper = value; }
        public string Use { get => this.use; set => this.use = value; }
        public string Sdate { get => this.sdate; set => this.sdate = value; }
        public string Edate { get => this.edate; set => this.edate = value; }
    }
}
