using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_2_Valid_Last_Name
{
    public class Pattern
    {
        public static string REGEX_CODE = "^[A-Z]{1}[a-z]{2}$";
        public bool Validate_LastName(string lastname)
        {
            return Regex.IsMatch(lastname, REGEX_CODE);
        }
    }
}
