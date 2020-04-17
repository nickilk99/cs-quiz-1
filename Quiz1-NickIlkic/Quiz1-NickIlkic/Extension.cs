using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class Extension
    {
        public static bool isDivBy3(this int i)
        {
            return (i % 3 == 0);
        }
    }
}
