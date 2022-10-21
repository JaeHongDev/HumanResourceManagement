using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    public class CodeGroupModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        private void PropertyChange(string propertyName)
        {
            if (PropertyChanged is null) return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

         private string cdg_grpcd;
        [Column("cdg_grpnm")] private string cdg_grpnm;
        [Column("cdg_digit")] private string cdg_digit;
        [Column("cdg_length")] private string cdg_length;
        [Column("cdg_use")] private string cdg_use;
        [Column("cdg_kind")] private string cdg_kind;
        [Column("cdg_grpcd")]
        public string Cdg_grpcd
        {
            get => cdg_grpcd; set
            {
                cdg_grpcd = value;
                PropertyChange("cdg_grpcd");
            }
        }
        public string Cdg_grpnm
        {
            get => cdg_grpnm; set { cdg_grpnm = value; PropertyChange("cdg_grpnm"); }
        }
        public string Cdg_digit
        {
            get => cdg_digit; set { cdg_digit = value; PropertyChange("cdg_digit"); }
        }
        public string Cdg_length
        {
            get => cdg_length; set { cdg_length = value; PropertyChange("cdg_length"); }
        }
        public string Cdg_use
        {
            get => cdg_use; set { cdg_use = value; PropertyChange("cdg_use"); }
        }
        public string Cdg_kind
        {
            get => cdg_kind; set { cdg_kind = value; PropertyChange("cdg_kind"); }
        }
    }
}