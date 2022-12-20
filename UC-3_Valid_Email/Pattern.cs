﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_3_Valid_Email
{
    public class Pattern
    {
        public static string REGEX_CODE = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2})?$";
        public bool Validate_Email(string email)
        {
            return Regex.IsMatch(email, REGEX_CODE);
        }
    }
}
