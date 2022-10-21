using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTaskModules.Utils
{
    /// <summary>
    /// convert string to byte Provider class
    /// </summary>
    public class StringToByte
    {
        
        /// <summary>
        /// this method is compare string that byte size to byteLength
        /// </summary>
        /// <param name="targetString">compared target string</param>
        /// <param name="byteLength">comapre byte size</param>
        public static bool LessThanStringToByteSize(string targetString,int byteLength)
        {
            byte[] encodedTargetString = Encoding.UTF8.GetBytes(targetString);
            return encodedTargetString.Length > byteLength;
        }
    }
}
