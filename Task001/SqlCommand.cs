using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task001
{
    public class SqlCommand
    {
        /// <summary>
        /// INSERT CodeGroup data
        /// </summary>
        public const string INSERT_GRPCD = @"INSERT INTO P22_PJH_TINSA_CDG
                    (cdg_grpcd, cdg_grpnm, cdg_digit, cdg_length, cdg_use, cdg_kind)  VALUES
                    (:cdg_grpcd,:cdg_grpnm,:cdg_digit,:cdg_length,:cdg_use,:cdg_kind)";

        /// <summary>
        /// Select CodeGroup data when name or usecase
        /// </summary>
        public const string SELECT_GRPCD_NAME_OR_USECASE = @"
        SELECT * FROM P22_PJH_TINSA_CDG WHERE CDG_GRPNM like :CDG_GRPNM AND CDG_USE like :CDG_USE ";

        public const string DELETE_GRPCD = @"
        DELETE FROM P22_PJH_TINSA_CDG WHERE CDG_GRPCD=:CRP_GRPCD";

        public const string UPDATE_GRPCD = @"
        UPDATE P22_PJH_TINSA_CDG
             SET
                CDG_GRPCD =:CDG_GRPCD,
                CDG_GRPNM =:CDG_GRPNM,
                CDG_DIGIT =:CDG_DIGIT,
                CDG_LENGTH =:CDG_LENGTH,
                CDG_USE =:CDG_USE,
                CDG_KIND =:CDG_KIND
             WHERE CDG_GRPCD =:CDG_GRPCD_CP";
    }
}
