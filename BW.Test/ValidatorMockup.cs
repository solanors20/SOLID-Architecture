using Entities;
using System;

namespace BW.Test
{
    public class ValidatorMockup : IUserValidator
    {
        public bool isEmailValid(string email)
        {
            return true;
        }

        public bool isNameValid(string name)
        {
            throw new NotImplementedException();
        }
    }
}
