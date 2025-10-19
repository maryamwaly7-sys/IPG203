using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace school_management_system
{
    public static class Validator
    {
        public static bool ValidateName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
}
