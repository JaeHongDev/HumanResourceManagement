using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class InsaBasicLicenseModel
    {
        private string employNo;
        private string licenseName;
        private string licenseGrade;
        private string acquisitionDate;
        private string licenseOrgan;
        [DisplayName("사원번호")] public string EmployNo { get => this.employNo; set => this.employNo = value; }
        [DisplayName("자격증명")] public string LicenseName { get => this.licenseName; set => this.licenseName = value; }
        [DisplayName("급수")] public string LicenseGrade { get => this.licenseGrade; set => this.licenseGrade = value; }
        [DisplayName("취득일")] public string AcquisitionDate { get => this.acquisitionDate; set => this.acquisitionDate = value; }
        [DisplayName("발급기관")] public string LicenseOrgan { get => this.licenseOrgan; set => this.licenseOrgan = value; }
    }
}
