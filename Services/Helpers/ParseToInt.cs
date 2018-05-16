using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public static class ParseToIntExtension
    {
        public static int ParseInt(this String number)
        {
            int iOut = 0;
            var value = int.TryParse(number, out iOut);
            if (value)
                return iOut;

            return -1;
        }
    }
}
