using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_4_Mobile_Format
{
    public class Pattern
    {
        public static string REGEX_CODE = "^+[1-9]{2}[: :][0-9]{10}$";
        public bool Validate_PhoneNumber(string phonenumber)
        {
            return Regex.IsMatch(phonenumber, REGEX_CODE);
        }
    }
}
