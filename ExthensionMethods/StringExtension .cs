using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System;
static class StringExtension
{
    public static string Cut(this string strObj, int count)
    {
        if(strObj.Length <=  count)
        {
            return strObj;
        }
        else
        {
            return strObj.Substring(0, count) + "...";
        }
    }
}
