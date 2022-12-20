using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_8_Password_Rule4
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^[a-zA-Z0-9]?[~`!@#$%^&*()-_+={}[]|\;:""<>,./?]{1,8}$";
        public bool Validate_Password(string password)
        {
            return Regex.IsMatch(password, REGEX_CODE);
        }
    }
}
