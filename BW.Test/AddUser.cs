using Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BW.Test
{
    [TestClass]
    public class AddUser
    {
        [TestMethod]
        public void validUser()
        {
            var userEntity = new UserEntity();
            userEntity.Email = "Test@gmail.com";
            var client = new TwitchUser(new UserRepoMockup(), new EmailMockup(), new ValidatorMockup());
            client.add(userEntity);
        }
    }
}
