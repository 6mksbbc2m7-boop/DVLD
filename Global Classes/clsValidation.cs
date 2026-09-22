using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace clsValidattion
{
    public class clsValidation
    {
        public static bool ValidateEmail(string EmailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9]+)*$";
            var regex = new Regex(pattern);
            return regex.IsMatch(EmailAddress);
        }
    }
}
