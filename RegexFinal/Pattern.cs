using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexFinal
{
    class Name
    {
        string Name_Validator = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateName(string result)
        {
            return Regex.IsMatch(result, Name_Validator);
        }
        public bool ValidateName1(string result1)
        {
            return Regex.IsMatch(result1, Name_Validator);
        }
    }
    public class Password
    {
        string PasswordValidator = "(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&*()_+]).{8,}$";

        public bool Validate(string name)
        {
            return Regex.IsMatch(name, PasswordValidator);
        }
    }
    class PhoneNum
    {
        string PhoneNoValidator = "^[91]{2}[ ]*[0-9]{10}$";

        public bool PhoneValidator(string name)
        {
            return Regex.IsMatch(name, PhoneNoValidator);
        }
    }

    class EmailId
    {
        string EmailIdValidator = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";

        public bool ValidateEmail(string name)
        {
            return Regex.IsMatch(name, EmailIdValidator);
        }
    }
}

