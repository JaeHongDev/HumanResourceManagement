using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModel.Model
{
    public class GroupCodeModel
    {
        private string groupCode;
        private string groupName;
        private string digit;
        private string length;
        private string use;
        private string kind;

          [DisplayName("그룹코드")] public string GroupCode { get => this.groupCode; set => this.groupCode = value; }
        [DisplayName("그룹코드명")] public string GroupName { get => this.groupName; set => this.groupName = value; }
        [DisplayName("단위코드 자리수")] public string Digit { get => this.digit; set => this.digit = value; }
        [DisplayName("단위코드명(원형) 길이")] public string Length { get => this.length; set => this.length = value; }
        [DisplayName("사용여부")] public string Use { get => this.use; set => this.use = value; }
        [DisplayName("분류")] public string Kind { get => this.kind; set => this.kind = value; }
    }
}
