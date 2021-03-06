﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Utility
    {
        public static string EncryptPassword(this string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password));
        }

        public static int Years(this DateTime date)
        {
            return DateTime.Now.Year - date.Year;
        }

        public static string SelectFileName(this string file)
        {
            return string.Join("", file.Reverse().TakeWhile(x => x != '\\').Reverse());
        }
    }
}
