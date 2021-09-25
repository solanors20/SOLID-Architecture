using Entities;
using System;

namespace BW.Test
{
    public class EmailMockup : IUserEmail
    {
        public void sendCofirmation(string email)
        {
            throw new NotImplementedException();
        }

        public void sendPasswordReset(string email)
        {
            throw new NotImplementedException();
        }
    }
}
