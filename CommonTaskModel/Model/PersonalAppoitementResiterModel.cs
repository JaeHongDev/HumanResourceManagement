using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class PersonalAppoitementResiterModel
    {
        private string papr_appno;
        private string papr_date;
        private string papr_content;
        private string papr_num;

        [DisplayName("인사발령번호")] public string Papr_appno { get => this.papr_appno; set => this.papr_appno = value; }
        [DisplayName("시행일자")] public string Papr_date { get => this.papr_date; set => this.papr_date = value; }
        [DisplayName("발령내용")] public string Papr_content { get => this.papr_content; set => this.papr_content = value; }
        [DisplayName("발령인원수")] public string Papr_num { get => this.papr_num; set => this.papr_num = value; }
    }
}
