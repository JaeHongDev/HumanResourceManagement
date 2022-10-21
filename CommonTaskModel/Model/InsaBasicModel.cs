using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicModel
    {
        private string employNo;
        private string resNo;
        private string name;
        private string cName;
        private string eName;
        private string fix;
        private string zip;
        private string addr;
        private string phoneNo;
        private string telNo;
        private string email;
        private string milstate;
        private string mil;
        private string millRank;
        private string marriged;
        private string accountBank;
        private string accountName;
        private string accountNo;
        private string contract;
        private string employSDate;
        private string employEDate;
        private string enterDate;
        private string leaveDate;
        private string restDate;
        private string rehabilitationDate;
        private string deptName;
        private string rankDate;
        private string positionDate;
        private string workState;
        private string states;
        private string postion;
        private string duration;
        private string dept;
        private string remark;

        [DisplayName("사원번호")] public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("주민등록번호")] public string ResNo { get => this.resNo; set => this.resNo = value; }
        [DisplayName("성명(한글)")] public string Name { get => this.name; set => this.name = value; }
        [DisplayName("성명(한자)")] public string CName { get => this.cName; set => this.cName = value; }
        [DisplayName("성명(영문)")] public string EName { get => this.eName; set => this.eName = value; }
        [DisplayName("성별")] public string Fix { get => this.fix; set => this.fix = value; }
        [DisplayName("우편번호")] public string Zip { get => this.zip; set => this.zip = value; }
        [DisplayName("주소")] public string Addr { get => this.addr; set => this.addr = value; }
        [DisplayName("연락처(휴대폰)")] public string PhoneNo { get => this.phoneNo; set => this.phoneNo = value; }
        [DisplayName("연락처(집)")] public string TelNo { get => this.telNo; set => this.telNo = value; }
        [DisplayName("이메일주소")] public string Email { get => this.email; set => this.email = value; }
        [DisplayName("병역(복무구분)")] public string Milstate { get => this.milstate; set => this.milstate = value; }
        [DisplayName("병역(군별)")] public string Mil { get => this.mil; set => this.mil = value; }
        [DisplayName("병역(계급)")] public string MillRank { get => this.millRank; set => this.millRank = value; }
        [DisplayName("결혼여부")] public string Marriged { get => this.marriged; set => this.marriged = value; }
        [DisplayName("계좌사항(은행명)")] public string AccountBank { get => this.accountBank; set => this.accountBank = value; }
        [DisplayName("계좌사항(예금주)")] public string AccountName { get => this.accountName; set => this.accountName = value; }
        [DisplayName("계좌사항(계좌번호)")] public string AccountNo { get => this.accountNo; set => this.accountNo = value; }
        [DisplayName("계약구분")] public string Contract { get => this.contract; set => this.contract = value; }
        [DisplayName("계약시작일")] public string EmploySDate { get => this.employSDate; set => this.employSDate = value; }
        [DisplayName("계약종료일")] public string EmployEDate { get => this.employEDate; set => this.employEDate = value; }
        [DisplayName("입사일자")] public string EnterDate { get => this.enterDate; set => this.enterDate = value; }
        [DisplayName("퇴사일자")] public string LeaveDate { get => this.leaveDate; set => this.leaveDate = value; }
        [DisplayName("휴직일자")] public string RestDate { get => this.restDate; set => this.restDate = value; }
        [DisplayName("복직일자")] public string RehabilitationDate { get => this.rehabilitationDate; set => this.rehabilitationDate = value; }
        [DisplayName("현부서일자")] public string DeptName { get => this.deptName; set => this.deptName = value; }
        [DisplayName("현직급일자")] public string RankDate { get => this.rankDate; set => this.rankDate = value; }
        [DisplayName("현직책일자")] public string PositionDate { get => this.positionDate; set => this.positionDate = value; }
        [DisplayName("재직상태")] public string WorkState { get => this.workState; set => this.workState = value; }
        [DisplayName("신분구분")] public string States { get => this.states; set => this.states = value; }
        [DisplayName("직급(현재)")] public string Postion { get => this.postion; set => this.postion = value; }
        [DisplayName("직책(현재)")] public string Duration { get => this.duration; set => this.duration = value; }
        [DisplayName("부서(현재)")] public string Dept { get => this.dept; set => this.dept = value; }
        [DisplayName("참고사항")] public string Remark { get => this.remark; set => this.remark = value; }
    }
}
