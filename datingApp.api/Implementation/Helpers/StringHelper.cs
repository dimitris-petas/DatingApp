using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace datingApp.api.Helpers
{
    //Extension Method for string
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inpuString)
        {
            if (inpuString.Length > 0)
            {
                char[] charArray = inpuString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ? char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            return inpuString;
        }
    }
}
