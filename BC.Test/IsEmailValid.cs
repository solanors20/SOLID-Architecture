using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BC.Test
{
    [TestClass]
    public class IsEmailValid
    {
        [TestMethod]
        public void EmptyEmail()
        {
            var testEmail = "";
            var validator = new UserValidator();
            var result = validator.isEmailValid(testEmail);
            Assert.IsFalse(result);
        }
    }
}
