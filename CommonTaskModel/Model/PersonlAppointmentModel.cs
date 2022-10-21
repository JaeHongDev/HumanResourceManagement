using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class PersonlAppointmentModel
    {
        private string papp_empno;
        private string papp_appno;
        private string papp_date;
        private string papp_pap;
        private string papp_content;
        private string papp_auth;
        private string papp_basis;
        private string papp_rmk;
        private string papp_pos_cd;
        private string papp_dut_cd;
        private string papp_dept_cd;
        private string papp_pos_nm;
        private string papp_dut_nm;
        private string papp_dept_nm;

        [DisplayName("사원번호")] public string Papp_empno { get => this.papp_empno; set => this.papp_empno = value; }
        [DisplayName("인사발령번호")] public string Papp_appno { get => this.papp_appno; set => this.papp_appno = value; }
        [DisplayName("시행일자")] public string Papp_date { get => this.papp_date; set => this.papp_date = value; }
        [DisplayName("발령종류")] public string Papp_pap { get => this.papp_pap; set => this.papp_pap = value; }
        [DisplayName("발령내용")] public string Papp_content { get => this.papp_content; set => this.papp_content = value; }
        [DisplayName("발령권자")] public string Papp_auth { get => this.papp_auth; set => this.papp_auth = value; }
        [DisplayName("발령근거")] public string Papp_basis { get => this.papp_basis; set => this.papp_basis = value; }
        [DisplayName("비고")] public string Papp_rmk { get => this.papp_rmk; set => this.papp_rmk = value; }
        [DisplayName("직급코드(당시)")] public string Papp_pos_cd { get => this.papp_pos_cd; set => this.papp_pos_cd = value; }
        [DisplayName("직책코드(당시)")] public string Papp_dut_cd { get => this.papp_dut_cd; set => this.papp_dut_cd = value; }
        [DisplayName("부서코드(당시)")] public string Papp_dept_cd { get => this.papp_dept_cd; set => this.papp_dept_cd = value; }
        [DisplayName("직급명(당시)")] public string Papp_pos_nm { get => this.papp_pos_nm; set => this.papp_pos_nm = value; }
        [DisplayName("직책명(당시)")] public string Papp_dut_nm { get => this.papp_dut_nm; set => this.papp_dut_nm = value; }
        [DisplayName("부서명(당시)")] public string Papp_dept_nm { get => this.papp_dept_nm; set => this.papp_dept_nm = value; }
    }
}
