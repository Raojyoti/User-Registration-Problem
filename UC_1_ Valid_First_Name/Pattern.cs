﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_1__Valid_First_Name
{
    public class Pattern
    {
        public static string REGEX_CODE = "^[A-Z]{1}[a-z]{2}$";
        public bool Validate_FirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_CODE);
        }
    }
}
