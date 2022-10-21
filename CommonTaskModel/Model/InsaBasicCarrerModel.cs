using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicCarrerModel
    {
        /*
         car_empno
            car_com
            car_region
            car_yyyymm_f
            car_yyyymm_t
            car_pos
            car_dept
            car_reason
         */
        private string employNo;
        private string placeOfWork;
        private string region;
        private string workStartDate;
        private string workEndDate;
        private string carrerPosition;
        private string carrerDept;
        private string reason;

        [DisplayName("사원번호")] public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("근무처명")] public string PlaceOfWork { get => this.placeOfWork; set => this.placeOfWork = value; }
        [DisplayName("소재지")] public string Region { get => this.region; set => this.region = value; }
        [DisplayName("근무시작월")] public string WorkStartDate { get => this.workStartDate; set => this.workStartDate = value; }
        [DisplayName("근무종료월")] public string WorkEndDate { get => this.workEndDate; set => this.workEndDate = value; }
        [DisplayName("최종직급")] public string CarrerPosition { get => this.carrerPosition; set => this.carrerPosition = value; }
        [DisplayName("담당부서")] public string CarrerDept { get => this.carrerDept; set => this.carrerDept = value; }
        [DisplayName("퇴직/이직사유")] public string Reason { get => this.reason; set => this.reason = value; }

    }
}
