using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryModules
{
    sealed class StringCompareHelper
    {
        public static bool CompareIgnoreCase(string a, string b) => string.Compare(a, b, true) == 0;
    }
}
