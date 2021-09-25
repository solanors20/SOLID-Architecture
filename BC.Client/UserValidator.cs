using Entities;
using System;

namespace BC
{
    public class UserValidator : IUserValidator
    {
        const int MINIMUM_USER_NAME_LENGTH = 4;
        public bool isEmailValid(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            else
                return true;
        }

        public bool isNameValid(string name)
        {
            if (string.IsNullOrEmpty(name) 
                && name.Length < MINIMUM_USER_NAME_LENGTH)
                return false;
            else
                return true;
        }
    }
}
